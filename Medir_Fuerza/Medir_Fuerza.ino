#include "HX711.h"

#define calibration_factor -21970       // This value is obtained using the SparkFun_HX711_Calibration sketch
#define offset 0

#define DOUT 15                         // Pines de la placa
#define CLK  2

HX711 scale;                            // Creamos el objeto scale

void setup() {
  Serial.begin(115200);
  scale.begin(DOUT, CLK);               // Inicializamos la balanza con el objeto scale
  Serial.println("HX711 scale demo");

  scale.set_scale(calibration_factor);  // Establecemos la escala
  scale.tare();                         // Taramos la balanza

  Serial.println("Readings:");
}

void loop() {
  Serial.print("Reading: ");
  Serial.print(scale.get_units(10) - offset, 1); // Nºde medidas = 10, luego hace la media
  Serial.print(",");
  Serial.print(" Kgs");
  Serial.println();
}

//  Serial.println(scale.read());               // Imprime el valor directo del ADC
//  Serial.println(scale.read_average(x));      // Imprime la media de x muestras
//  Serial.println(scale.get_value(x));         // Imprime la media de x muestras - la tara
//  Serial.println(scale.get_units(x), 1);      // Imprime la media de (x muestras - la tara)/scale factor
