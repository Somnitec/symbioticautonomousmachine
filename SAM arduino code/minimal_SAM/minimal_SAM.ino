#define statusLedPin 13
#define ledPinTop 11
#define ledPinMiddle 10
#define ledPinBottom 9
#define button2pin 8
#define button1pin 7
#define button2ledpin 6
#define button1ledpin 5
#define pumpPin 3
#define flowSensorPin 2


void setup() {  
  
  pinMode(ledPinTop,OUTPUT);
  pinMode(ledPinMiddle,OUTPUT);
  pinMode(ledPinBottom,OUTPUT);
  
  pinMode(button1pin, INPUT_PULLUP);
  pinMode(button2pin, INPUT_PULLUP);
  pinMode(button1ledpin,OUTPUT);
  pinMode(button2ledpin,OUTPUT);

  pinMode(pumpPin,OUTPUT);

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
  digitalWrite(pumpPin,HIGH);
  delay(500);
  digitalWrite(pumpPin,LOW);
  delay(500);
}
