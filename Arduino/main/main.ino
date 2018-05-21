#include <SerialCommand.h>

SerialCommand sCmd;

// Angle between spokes in wheel.
const int angBetweenSpokes = 15;

// Refresh Rate of Velocity in Hz
const int velocityRefreshRate = 200;

// Boundary between darkness and exposure to LED.
const int lightBurstBoundary = 100;

// Left wheel counter of bursts.
int leftCounter = 0;

// Left wheel LRD A pin.
int leftAPin = A0;

// Left wheel LRD B pin.
int leftBPin = A1;

// Left wheel LRD A state.
bool leftALastBurstState;

// Time since last measurement of velocity.
unsigned long loopTime;

// Global time since start.
unsigned long currentTime;

// Method declarations.
int calculateAngulerVelocity(int counter);
int checkWheelChanges(int pinA, bool lastBurstAState, int pinB);
bool checkBurstState(int pin);

void setup() {
  pinMode(leftAPin, INPUT);
  pinMode(leftBPin, INPUT);

  leftALastBurstState = checkBurstState(leftAPin);

  currentTime = millis();
  loopTime = currentTime;
  
  Serial.begin(9600);
  while (!Serial);
}

void loop() {

  currentTime = millis();

  // If refresh time, calculate the amount of angle turned in deg/ms.
  if (currentTime >= (loopTime + velocityRefreshRate)) {
    int leftOutput = calculateAngularVelocity(leftCounter);
    leftCounter = 0;
    Serial.print(leftOutput);
    loopTime = currentTime;
  } else {
    // Update the counter for bursts.
    leftCounter += checkWheelChanges(leftAPin, leftALastBurstState, leftBPin);
  }
  
  int leftAValue = analogRead(leftAPin);
  int leftBValue = analogRead(leftBPin);
  
  Serial.print(leftAValue);
  Serial.print(" ");
  Serial.println(leftBValue);
   
}

// Calculate the angular velocity from the time taken.
int calculateAngularVelocity(int counter) {
  int timePassed = 1000/velocityRefreshRate;
  return (counter * angBetweenSpokes) / timePassed;
}

// Return adjustment to wheel counter.
int checkWheelChanges(int pinA, bool lastABurstState, int pinB)
{
  if (checkBurstState(pinA) != lastABurstState) {
    if (checkBurstState(pinB) != lastABurstState) {
		  return 1;
    } else {
      return -1;
    }
  }
  return 0;
}

// Check state of pin.
bool checkBurstState(int pin) {
  if (analogRead(pin) > lightBurstBoundary)
  {
    return true;
  }
  return false;
}
