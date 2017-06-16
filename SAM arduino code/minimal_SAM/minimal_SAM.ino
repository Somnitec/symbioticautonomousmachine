#define statusLedPin 13
#define ledPinTop 11
#define ledPinMiddle 10
#define ledPinBottom 9
#define button2pin 8
#define button1pin 7
#define button2ledpin 6
#define button1ledpin 5
#define pumpPin 3
#define flowSensorPin 2// 1L = 5880 pulses

volatile double waterFlow = 0;

void setup() {

  pinMode(ledPinTop, OUTPUT);
  pinMode(ledPinMiddle, OUTPUT);
  pinMode(ledPinBottom, OUTPUT);

  pinMode(button1pin, INPUT_PULLUP);
  pinMode(button2pin, INPUT_PULLUP);
  pinMode(button1ledpin, OUTPUT);
  pinMode(button2ledpin, OUTPUT);

  pinMode(pumpPin, OUTPUT);

  attachInterrupt(0, flowSensor, RISING); //flowsensor setup

  Serial.begin(9600);
}

void loop() {
  /*
    digitalWrite(button1ledpin,!digitalRead(button1pin));
    digitalWrite(button2ledpin,!digitalRead(button2pin));
    Serial.print(!digitalRead(button1pin));
    Serial.print('\t');
    Serial.print(!digitalRead(button2pin));
    Serial.println();
    delay(50);
  */
  /*
    digitalWrite(ledPinTop,HIGH);
    digitalWrite(ledPinMiddle,LOW);
    digitalWrite(ledPinBottom,LOW);
    delay(500);
    digitalWrite(ledPinTop,LOW);
    digitalWrite(ledPinMiddle,HIGH);
    digitalWrite(ledPinBottom,LOW);
    delay(500);
    digitalWrite(ledPinTop,LOW);
    digitalWrite(ledPinMiddle,LOW);
    digitalWrite(ledPinBottom,HIGH);
    delay(500);
  */
  /*
    digitalWrite(pumpPin,HIGH);
    delay(500);
    digitalWrite(pumpPin,LOW);
    delay(500);
  */
  Serial.print("waterFlow: ");
  Serial.print(waterFlow,3);
  Serial.println(" mL");
  delay(500);
}

void flowSensor()   //measure the quantity of square wave
{
  waterFlow += 1.0 / 5.880;
}
