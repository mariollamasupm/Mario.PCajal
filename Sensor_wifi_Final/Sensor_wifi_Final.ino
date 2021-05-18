
#ifdef ESP32
  #include <WiFi.h>
  #include <ESPAsyncWebServer.h>
  #include <SPIFFS.h>
#else
  #include <Arduino.h>
  #include <ESP8266WiFi.h>
  #include <Hash.h>
  #include <ESPAsyncTCP.h>
  #include <ESPAsyncWebServer.h>
  #include <FS.h>
#endif
#include <Wire.h>

const char* ssid = "Mario";
const char* password = "mariollamas";

//const char* ssid = "Mosqueperros";
//const char* password = "kirbyroblink.3";

// Create AsyncWebServer object on port 80
AsyncWebServer server(80);

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

int d = 1;  // Valor del delay

void setup() {
  // put your setup code here, to run once:

  Serial.begin(115200);
  delay(500);
  
  // Initialize SPIFFS
  if(!SPIFFS.begin()){
    Serial.println("An Error has occurred while mounting SPIFFS");
    return;
  }

  WiFi.begin(ssid,password);
    while (WiFi.status() != WL_CONNECTED) {
      delay(500);
      Serial.println("Connecting to WiFi..");
    }

  Serial.println("Connected to the WiFi network");
  Serial.println(WiFi.localIP());

  // Route for root / web page
  server.on("/", HTTP_GET, [](AsyncWebServerRequest *request){
    request->send(SPIFFS, "/index.html");
  });
  server.on("/sensor1", HTTP_GET, [](AsyncWebServerRequest *request){
    request->send_P(200, "text/plain", String(potValue1).c_str());
    Serial.print("Sensor 1: ");
    Serial.println(potValue1);
  });
  server.on("/sensor2", HTTP_GET, [](AsyncWebServerRequest *request){
    request->send_P(200, "text/plain", String(potValue2).c_str());
    Serial.print("Sensor 2: ");
    Serial.println(potValue2);
  });
  server.on("/sensor3", HTTP_GET, [](AsyncWebServerRequest *request){
    request->send_P(200, "text/plain", String(potValue3).c_str());
    Serial.print("Sensor 3: ");
    Serial.println(potValue3);
  });
  server.on("/sensor4", HTTP_GET, [](AsyncWebServerRequest *request){
    request->send_P(200, "text/plain", String(potValue4).c_str());
    Serial.print("Sensor 4: ");
    Serial.println(potValue4);
  });
  server.on("/sensor5", HTTP_GET, [](AsyncWebServerRequest *request){
    request->send_P(200, "text/plain", String(potValue5).c_str());
    Serial.print("Sensor 5: ");
    Serial.println(potValue5);
  });
  server.on("/sensor6", HTTP_GET, [](AsyncWebServerRequest *request){
    request->send_P(200, "text/plain", String(potValue6).c_str());
    Serial.print("Sensor 6: ");
    Serial.println(potValue6);
  });

  // Start server
  server.begin();

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

  //Serial.println((String) potValue1 + "A" + potValue2 + "B" + potValue3 + "C" + potValue4 + "D" + potValue5 + "E" + potValue6 + "F");
 
}
