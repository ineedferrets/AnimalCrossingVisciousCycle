
void setup() {
  // put your setup code here, to run once:
pinMode(PA15, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(PA15, HIGH);   // Turn the built-in LED on
  delay(5000);                       // Pause for 1 second (1000 milliseconds)
  
  digitalWrite(PA15, LOW);    // Turn the built-in LED on
  delay(1000);   
}
