const int ledPin1 = 14;
const int ledPin2 = 26;
const int ledPin3 = 25;
const int ledPin4 = 13;
const int ledPin5 = 12;
const int ledPin6 = 27;

const int potPin = 33;
int potValue = 0;
int potValue1 = 0;
int potValue2 = 0;
int potValue3 = 0;
int potValue4 = 0;
int potValue5 = 0;
int potValue6 = 0;

int d = 1;


void setup() {
  Serial.begin(115200);
  delay(500);
  
  pinMode(ledPin1, OUTPUT);
 pinMode(ledPin2, OUTPUT);
 pinMode(ledPin3, OUTPUT);
 pinMode(ledPin4, OUTPUT);
 pinMode(ledPin5, OUTPUT);
 pinMode(ledPin6, OUTPUT);
}

void loop() {
  
  digitalWrite(ledPin1, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(d);
  potValue1 = analogRead(potPin);
  digitalWrite(ledPin1, LOW);
  delay(d);

  digitalWrite(ledPin2, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(d);
  potValue2 = analogRead(potPin);
  digitalWrite(ledPin2, LOW);
  delay(d);

  digitalWrite(ledPin3, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(d);
  potValue3 = analogRead(potPin);
  digitalWrite(ledPin3, LOW);
  delay(d);

  digitalWrite(ledPin4, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(d);
  potValue4 = analogRead(potPin);
  digitalWrite(ledPin4, LOW);
  delay(d);

  digitalWrite(ledPin5, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(d);
  potValue5 = analogRead(potPin);
  digitalWrite(ledPin5, LOW);
  delay(d);

  digitalWrite(ledPin6, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(d);
  potValue6 = analogRead(potPin);
  digitalWrite(ledPin6, LOW);
  delay(d);

//  Serial.println((String) potValue1 + "A" + potValue2 + "B" + potValue3 + "C" + potValue4 + "D" + potValue5 + "E" + potValue6 + "F");
  Serial.println((String) 1550 + "A" + 1400 + "B" + 1600 + "C" + 1500 + "D" + 1530 + "E" + 1250 + "F");
  
}



  


  
