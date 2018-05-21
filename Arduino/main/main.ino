//#define NATIVE_USB

//#include "SoftwareSerial.h"
//#include "SerialCommand.h"
//SerialCommand sCmd;

float leftWheelAngVel;
float rightWheelAngVel;

void setup() {

  Serial.begin(1200);

  Serial.write("Begun running");
  
  //SerialUSB.begin(1);

  //sCmd.addCommand("PING", pingHandler);
  //sCmd.addCommand("REQUEST", requestHandler);
}

void loop() {
  Serial.write("Running...\n");
  //SerialUSB.println("I'm pringint a lint");
}

void pingHandler()
{
  //Serial.println("PONG");
}

void requestHandler()
{
	//String outputString = String(String(leftWheelAngVel) + " " + String(rightWheelAngVel));
  
	//Serial.println(outputString);
}

