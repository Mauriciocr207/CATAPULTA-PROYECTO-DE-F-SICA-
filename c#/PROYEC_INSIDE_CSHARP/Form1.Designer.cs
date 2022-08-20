namespace PROYEC_INSIDE_CSHARP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.ButtonApuntar = new System.Windows.Forms.Button();
            this.ButtonRecargar = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVelocidadangular = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.ButtonCalcular = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.lblTiempo_motor = new System.Windows.Forms.Label();
            this.lblAlturaMaxima = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ButtonConnectar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.comboBoxPuerto = new System.Windows.Forms.ComboBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.GroupBox3.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.GroupBox3.Controls.Add(this.GroupBox5);
            this.GroupBox3.Controls.Add(this.GroupBox4);
            this.GroupBox3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupBox3.Location = new System.Drawing.Point(231, 336);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(781, 231);
            this.GroupBox3.TabIndex = 5;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "CONTROL DE DATOS";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.ButtonApuntar);
            this.GroupBox5.Controls.Add(this.ButtonRecargar);
            this.GroupBox5.Location = new System.Drawing.Point(483, 21);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(279, 197);
            this.GroupBox5.TabIndex = 16;
            this.GroupBox5.TabStop = false;
            // 
            // ButtonApuntar
            // 
            this.ButtonApuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.ButtonApuntar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonApuntar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.ButtonApuntar.Location = new System.Drawing.Point(24, 123);
            this.ButtonApuntar.Name = "ButtonApuntar";
            this.ButtonApuntar.Size = new System.Drawing.Size(240, 53);
            this.ButtonApuntar.TabIndex = 18;
            this.ButtonApuntar.Text = "APUNTAR";
            this.ButtonApuntar.UseVisualStyleBackColor = false;
            this.ButtonApuntar.Click += new System.EventHandler(this.ButtonApuntar_Click);
            // 
            // ButtonRecargar
            // 
            this.ButtonRecargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(183)))));
            this.ButtonRecargar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRecargar.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonRecargar.Location = new System.Drawing.Point(24, 40);
            this.ButtonRecargar.Name = "ButtonRecargar";
            this.ButtonRecargar.Size = new System.Drawing.Size(240, 61);
            this.ButtonRecargar.TabIndex = 17;
            this.ButtonRecargar.Text = "RECARGAR";
            this.ButtonRecargar.UseVisualStyleBackColor = false;
            this.ButtonRecargar.Click += new System.EventHandler(this.ButtonRecargar_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.label14);
            this.GroupBox4.Controls.Add(this.txtVelocidadangular);
            this.GroupBox4.Controls.Add(this.label13);
            this.GroupBox4.Controls.Add(this.Label5);
            this.GroupBox4.Controls.Add(this.Label4);
            this.GroupBox4.Controls.Add(this.Label3);
            this.GroupBox4.Controls.Add(this.Label2);
            this.GroupBox4.Controls.Add(this.txtDistancia);
            this.GroupBox4.Controls.Add(this.txtVelocidad);
            this.GroupBox4.Controls.Add(this.ButtonCalcular);
            this.GroupBox4.Location = new System.Drawing.Point(17, 21);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(442, 197);
            this.GroupBox4.TabIndex = 0;
            this.GroupBox4.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(166, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 21);
            this.label14.TabIndex = 18;
            this.label14.Text = "rad/s";
            // 
            // txtVelocidadangular
            // 
            this.txtVelocidadangular.Location = new System.Drawing.Point(36, 147);
            this.txtVelocidadangular.Name = "txtVelocidadangular";
            this.txtVelocidadangular.Size = new System.Drawing.Size(115, 29);
            this.txtVelocidadangular.TabIndex = 17;
            this.txtVelocidadangular.Text = "0.443727775693";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 30);
            this.label13.TabIndex = 16;
            this.label13.Text = "VELOCIDAD ANG";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Label5.Location = new System.Drawing.Point(393, 80);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(26, 21);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "m";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(157, 80);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 21);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "m/s";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(267, 29);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(138, 30);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "DISTANCIA";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(21, 29);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(148, 30);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "VELOCIDAD";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(272, 77);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(115, 29);
            this.txtDistancia.TabIndex = 13;
            this.txtDistancia.Text = "0";
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(36, 75);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(115, 29);
            this.txtVelocidad.TabIndex = 12;
            this.txtVelocidad.Text = "5.40592175";
            // 
            // ButtonCalcular
            // 
            this.ButtonCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.ButtonCalcular.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.ButtonCalcular.Location = new System.Drawing.Point(264, 123);
            this.ButtonCalcular.Name = "ButtonCalcular";
            this.ButtonCalcular.Size = new System.Drawing.Size(128, 53);
            this.ButtonCalcular.TabIndex = 11;
            this.ButtonCalcular.Text = "CALCULAR";
            this.ButtonCalcular.UseVisualStyleBackColor = false;
            this.ButtonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.GroupBox2.Controls.Add(this.pictureBox2);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.lblAngulo);
            this.GroupBox2.Controls.Add(this.lblTiempo_motor);
            this.GroupBox2.Controls.Add(this.lblAlturaMaxima);
            this.GroupBox2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupBox2.Location = new System.Drawing.Point(231, 17);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(781, 299);
            this.GroupBox2.TabIndex = 4;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "GRÁFICA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROYEC_INSIDE_CSHARP.Properties.Resources.Captura_de_pantalla__168_;
            this.pictureBox2.Location = new System.Drawing.Point(17, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(565, 253);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(603, 188);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(134, 21);
            this.Label8.TabIndex = 12;
            this.Label8.Text = "Tiempo de giro";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(645, 112);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(67, 21);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Ángulo";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(610, 37);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(137, 21);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Altura máxima:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.Label11.Location = new System.Drawing.Point(609, 246);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(0, 21);
            this.Label11.TabIndex = 9;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.Label10.Location = new System.Drawing.Point(609, 164);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(0, 21);
            this.Label10.TabIndex = 8;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.Label9.Location = new System.Drawing.Point(610, 78);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(0, 21);
            this.Label9.TabIndex = 7;
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.lblAngulo.Location = new System.Drawing.Point(645, 148);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(15, 21);
            this.lblAngulo.TabIndex = 6;
            this.lblAngulo.Text = "-";
            // 
            // lblTiempo_motor
            // 
            this.lblTiempo_motor.AutoSize = true;
            this.lblTiempo_motor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.lblTiempo_motor.Location = new System.Drawing.Point(645, 221);
            this.lblTiempo_motor.Name = "lblTiempo_motor";
            this.lblTiempo_motor.Size = new System.Drawing.Size(15, 21);
            this.lblTiempo_motor.TabIndex = 5;
            this.lblTiempo_motor.Text = "-";
            // 
            // lblAlturaMaxima
            // 
            this.lblAlturaMaxima.AutoSize = true;
            this.lblAlturaMaxima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.lblAlturaMaxima.Location = new System.Drawing.Point(645, 68);
            this.lblAlturaMaxima.Name = "lblAlturaMaxima";
            this.lblAlturaMaxima.Size = new System.Drawing.Size(15, 21);
            this.lblAlturaMaxima.TabIndex = 4;
            this.lblAlturaMaxima.Text = "-";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.GroupBox1.Controls.Add(this.progressBarConnection);
            this.GroupBox1.Controls.Add(this.label12);
            this.GroupBox1.Controls.Add(this.comboBoxBaudRate);
            this.GroupBox1.Controls.Add(this.ButtonDisconnect);
            this.GroupBox1.Controls.Add(this.ButtonConnectar);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.comboBoxPuerto);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GroupBox1.Location = new System.Drawing.Point(17, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(194, 555);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "PUERTO";
            // 
            // progressBarConnection
            // 
            this.progressBarConnection.Location = new System.Drawing.Point(18, 217);
            this.progressBarConnection.Name = "progressBarConnection";
            this.progressBarConnection.Size = new System.Drawing.Size(155, 23);
            this.progressBarConnection.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Baud Reate";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(38, 164);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 31);
            this.comboBoxBaudRate.TabIndex = 4;
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.ButtonDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.ButtonDisconnect.Location = new System.Drawing.Point(18, 324);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(155, 51);
            this.ButtonDisconnect.TabIndex = 3;
            this.ButtonDisconnect.Text = "DESCONECTAR";
            this.ButtonDisconnect.UseVisualStyleBackColor = false;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // ButtonConnectar
            // 
            this.ButtonConnectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.ButtonConnectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.ButtonConnectar.Location = new System.Drawing.Point(18, 258);
            this.ButtonConnectar.Name = "ButtonConnectar";
            this.ButtonConnectar.Size = new System.Drawing.Size(155, 46);
            this.ButtonConnectar.TabIndex = 2;
            this.ButtonConnectar.Text = "CONECTAR";
            this.ButtonConnectar.UseVisualStyleBackColor = false;
            this.ButtonConnectar.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(29, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(142, 23);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Elige el puerto";
            // 
            // comboBoxPuerto
            // 
            this.comboBoxPuerto.FormattingEnabled = true;
            this.comboBoxPuerto.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboBoxPuerto.Location = new System.Drawing.Point(38, 73);
            this.comboBoxPuerto.Name = "comboBoxPuerto";
            this.comboBoxPuerto.Size = new System.Drawing.Size(121, 31);
            this.comboBoxPuerto.TabIndex = 0;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::PROYEC_INSIDE_CSHARP.Properties.Resources.NASA_logo;
            this.PictureBox1.Location = new System.Drawing.Point(33, 415);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(126, 106);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1029, 579);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BABAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Button ButtonRecargar;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtDistancia;
        internal System.Windows.Forms.TextBox txtVelocidad;
        internal System.Windows.Forms.Button ButtonCalcular;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label lblAngulo;
        internal System.Windows.Forms.Label lblTiempo_motor;
        internal System.Windows.Forms.Label lblAlturaMaxima;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button ButtonDisconnect;
        internal System.Windows.Forms.Button ButtonConnectar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox comboBoxPuerto;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button ButtonApuntar;
        internal System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBarConnection;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtVelocidadangular;
        internal System.Windows.Forms.Label label13;
    }
}

