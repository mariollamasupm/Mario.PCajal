#include "HX711.h"
#define DOUT  15
#define CLK  2
HX711 scale;
float calibration_factor = -22000;

const int ledPin = 14;    // Led 1
//const int ledPin = 26;    // Led 2
//const int ledPin = 25;    // Led 3
//const int ledPin = 13;    // Led 4
//const int ledPin = 12;    // Led 5
//const int ledPin = 27;    // Led 6

const int potPin = 33;
int potValue = 0;

int d = 1;

void setup() {
  Serial.begin(115200);
  delay(500);
  pinMode(ledPin, OUTPUT);

  scale.begin(DOUT, CLK);
  scale.set_scale(calibration_factor);
  scale.tare();
}

void loop() {
  digitalWrite(ledPin, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(d);
  potValue = analogRead(potPin);
  digitalWrite(ledPin, LOW);
  delay(d);
  
  Serial.print(potValue);
  Serial.print(",");
  Serial.print(scale.get_units(), 1);
  Serial.println();
}



  


  
