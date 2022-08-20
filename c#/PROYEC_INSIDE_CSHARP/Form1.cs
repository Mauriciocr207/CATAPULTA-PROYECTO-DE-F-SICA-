using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYEC_INSIDE_CSHARP
{
    public partial class Form1 : Form
    {
        double Velocidad;
        double Angulo1;
        double Angulo2;
        double AnguloGrados;
        double VelY;
        double tiempo;
        double AlturaMaxima;
        double DistanciaMaxima;
        double gravedad = 9.8;
        double Velocidad_angular;
        double tiempo_giro_motor;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonDisconnect.Enabled = false;
            ButtonRecargar.Enabled = false;
            ButtonApuntar.Enabled = false;
            comboBoxBaudRate.Text = "9600";
            progressBarConnection.Value = 0;
        }
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxPuerto.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPort1.Open();
                progressBarConnection.Value = 100;

                ButtonDisconnect.Enabled = true;

                ButtonRecargar.Enabled = true;
                ButtonApuntar.Enabled = true;
                comboBoxBaudRate.Enabled = false;
                comboBoxPuerto.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            //Adquirir velocidad y distancia del textbook
            Velocidad = Convert.ToDouble(txtVelocidad.Text);
            DistanciaMaxima = Convert.ToDouble(txtDistancia.Text);

            //Calcular angulo
            Angulo1 = Math.Asin((gravedad) * DistanciaMaxima / Math.Pow(Velocidad, 2)) / 2;

            //Calcular los componentes de la velocidad
            VelY = Velocidad * Math.Sin(Angulo1);

            //Calcular tiempo de altura máxima
            tiempo = (VelY) / gravedad;
            //Calcular la altura máxima
            AlturaMaxima = VelY * tiempo + (gravedad * Math.Pow(tiempo, 2) / 2);
            //Mostrar resultado de altura máxima
            lblAlturaMaxima.Text = AlturaMaxima.ToString("n") + "m";

            //Calcular tiempo total en el aire
            tiempo *= 2;
            lblTiempo_motor.Text = tiempo.ToString("n") + "seg";

            //Existen dos valores para el ángulo. Dados por una raiz --> + / -
            Angulo2 = Math.Asin(Math.Sqrt((2 * AlturaMaxima * (-gravedad)) / (Math.Pow(Velocidad, 2))));
            AnguloGrados = Math.Round(Angulo1 * 180 / Math.PI, 2);
            lblAngulo.Text = AnguloGrados + "°";

            //Calulamos el tiempo de giro del motor
            Velocidad_angular = Convert.ToDouble(txtVelocidadangular.Text);
            tiempo_giro_motor = Angulo1 / Velocidad_angular;
            lblTiempo_motor.Text = tiempo_giro_motor.ToString("n") + "seg";

        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBarConnection.Value = 0;
            ButtonDisconnect.Enabled = false;
            ButtonCalcular.Enabled = false;
            ButtonRecargar.Enabled = false;
            ButtonApuntar.Enabled = false;
            comboBoxBaudRate.Enabled = true;
            comboBoxPuerto.Enabled = true;
        }

        private void ButtonApuntar_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(Convert.ToString(tiempo_giro_motor));
        }

        private void ButtonRecargar_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("r ");
        }
    }
}
