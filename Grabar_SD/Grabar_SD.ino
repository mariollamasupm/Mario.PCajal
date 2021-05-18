#include "FS.h"
#include "SD.h"
#include "SPI.h"

const int ledPin1 = 14;
const int ledPin2 = 26;
const int ledPin3 = 25;
const int ledPin4 = 13;
const int ledPin5 = 12;
const int ledPin6 = 27;

const int potPin = 33;
int potValue1 = 1;
int potValue2 = 2;
int potValue3 = 3;
int potValue4 = 4;
int potValue5 = 5;
int potValue6 = 6;

int d = 1;

String send_string;
const int size_char = 31;   // Cada medida del sensor = 4 dig
char send_char[size_char];

void writeFile(fs::FS &fs, const char * path, const char * message) {
  Serial.printf("Writing file: %s\n", path);

  File file = fs.open(path, FILE_WRITE);
  if (!file) {
    Serial.println("Failed to open file for writing");
    return;
  }
  if (file.print(message)) {
    Serial.println("File written");
  } else {
    Serial.println("Write failed");
  }
  file.close();
}

void appendFile(fs::FS &fs, const char * path, const char * message) {
  Serial.printf("Appending to file: %s\n", path);

  File file = fs.open(path, FILE_APPEND);
  if (!file) {
    Serial.println("Failed to open file for appending");
    return;
  }
  if (file.print(message)) {
    Serial.println("Message appended");
  } else {
    Serial.println("Append failed");
  }
  file.close();
}

void readFile(fs::FS &fs, const char * path) {
  Serial.printf("Reading file: %s\n", path);

  File file = fs.open(path);
  if (!file) {
    Serial.println("Failed to open file for reading");
    return;
  }

  Serial.print("Read from file: ");
  while (file.available()) {
    Serial.write(file.read());
  }
  Serial.println(" ");
  file.close();
}

void setup() {
  Serial.begin(115200);
  if (!SD.begin()) {
    Serial.println("Card Mount Failed");
    return;
  }
  writeFile(SD, "/Test1.txt", "Medidas de presión: \n");
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

  // GRABAMOS:
  send_string = (String)potValue1 + "," + potValue2 + "," + potValue3 + "," + potValue4 + "," + potValue5 + "," + potValue6 + ",";
  Serial.println(send_string);
  
  send_string.toCharArray(send_char, size_char);
  Serial.println(send_char);

  appendFile(SD, "/Test1.txt", send_char);
  readFile(SD, "/Test1.txt");


}
//  itoa(potValue1,v1,10); Cambia de int a char*
