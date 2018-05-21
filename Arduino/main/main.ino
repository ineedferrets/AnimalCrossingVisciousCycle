#include <SoftwareSerial.h>
#include "SerialCommand.h"
SerialCommand sCmd;

float leftWheelAngVel;
float rightWheelAngVel;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  while(!Serial);

  sCmd.addCommand("PING", pingHandler);
  sCmd.addCommand("REQUEST", requestHandler);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available() > 0)
    sCmd.readSerial();
}

void pingHandler()
{
  Serial.println("PONG");
}

void requestHandler()
{
	String outputString = String(String(leftWheelAngVel) + " " + String(rightWheelAngVel));
  
	Serial.println(outputString);
}

