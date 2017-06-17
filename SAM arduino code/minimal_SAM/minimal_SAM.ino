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

#define  buttonUpdateTime 10//ms
#define  flowUpdateTime 1000//ms
#define  ledUpdateTime 500//ms

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
  buttonStuff();
  flowStuff();
  ledStuff();
}


