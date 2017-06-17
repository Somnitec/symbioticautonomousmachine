/*
  notes
  !!!get new smaller slangklemmen
  Tap closed works, but water sprays out because of leaky clamps

  todo

  (grain button to error animation)
  Pushbutton animations


  pushbutton to tap
  Ticket printing after tapping finished
  izettle/sumup bluetooth distance test
*/

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
#define  flowUpdateTime 10//ms
#define  ledUpdateTime 5//ms

#define ledBreathSpeed 0.05
#define ledBreathMax 50
#define ledBreathMin 20

int deviceState = 0;
//0=idle
//1=sodabutton pressed, waiting for izettle
//2=grain button pressed -> error
//3=(attempting to) pumping (potentially changing lightness towards fuller cup)
//4=cup full, printing note

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
  //flowStuff();
  ledStuff();
}

float fmap(float x, float in_min, float in_max, float out_min, float out_max)
{
  return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
}
