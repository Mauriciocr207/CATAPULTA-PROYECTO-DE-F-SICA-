#include <AFMotor.h>
#include <Servo.h>
double variable = 0, variable_2 = 0;
int a = 0; 
unsigned long tiempo;
String cadena;
AF_DCMotor motor1(1);
AF_DCMotor motor2(2);

//Condiciones iniciales
void setup() {
  tiempo = millis();
  motor1.setSpeed(255);
  motor2.setSpeed(255);
  Serial.begin(9600);
}


void loop() {
  //Si hay una entrada, se guarda el valor del tiempo
  if(Serial.available() > 0){    
    cadena = Serial.readStringUntil('\n');
    cadena = cadena.substring(0, cadena.length() - 1);
    tiempo = millis();
  }
  //Si mandamos la letra r, se produce una reversa en el tiempo mandado con anterioridad
   if(cadena == "r"){
      if(millis()-tiempo <= variable_2 * 1000){
        Serial.println("RECARGA"); 
        motor1.run(BACKWARD);
        motor2.run(BACKWARD);
      }
     if(millis()-tiempo > variable_2 * 1000 ){
        motor1.run(RELEASE);
        motor2.run(RELEASE);
        Serial.println("Detenido EN RECARGA"); 
        cadena = ""; 
      }
   }
   //Si mandamos cualquier tiempo, el motor avanza ese tiempo
    else {
      variable = cadena.toFloat();
     if(millis()-tiempo <= variable * 1000){
        Serial.println("ADELANTE"); 
        motor1.run(FORWARD);
        motor2.run(FORWARD);
        variable_2 = variable; 
      }
     if(millis()-tiempo > variable * 1000 ){
        motor1.run(RELEASE);
        motor2.run(RELEASE);
        Serial.println("Detenido EN ADELANTE"); 
        cadena = ""; 
      }  
    }    
}
