#include <Bounce2.h>
#include <CmdMessenger.h>  // CmdMessenger

CmdMessenger cmdMessenger = CmdMessenger(Serial);

#define statusLedPin 13 
#define ledPinTop 11 //timer2
#define ledPinMiddle 10 //timer1
#define ledPinBottom 9 //timer1
#define grainButtonPin 8 
#define sodaButtonPin 7 
#define grainButtonLedPin 6
#define sodaButtonLedPin 5
#define pumpPin 3
#define flowSensorPin 2// 1L = 5880 pulses

volatile double waterFlow = 0;

#define  buttonUpdateTime 1//ms
#define  flowUpdateTime 1//ms
#define  ledUpdateTime 10//ms
#define  serialUpdateTime 1//ms

//idle animation
float ledBreathSpeed = 0.02;
int ledBreathMax = 50;
int ledBreathMin = 20;

//waiting animation


//error
#define blinkOnTime 100
#define blinkOffTime 120
#define amountOfBlinks 2

#define blinkBrightness 30

//pumping
boolean nowTapping = false;
int tapAmount = 0;

//printing


Bounce sodaButton = Bounce();
Bounce grainButton = Bounce();
void setup()
{
  //improving PWM speed
  //ideal speed is = 

  //timer 2 = pin 11 = top vat
  TCCR2B = TCCR2B & 0b11111000 | 0x02; //=3921 Hz instead of 490 Hz
  //timer 1 = pins 10 & 9 = middle and bottom vat
  TCCR1B = TCCR1B & 0b11111000 | 0x02;//=3921 Hz instead of 490 Hz
  //timer ?? = pins 8 & 7 = buttons  
  //TCCR4B = TCCR4B & 0b11111000 | 0x01;  
  
  setupSerial();

  pinMode(statusLedPin, OUTPUT);

  pinMode(ledPinTop, OUTPUT);
  pinMode(ledPinMiddle, OUTPUT);
  pinMode(ledPinBottom, OUTPUT);

  pinMode(sodaButtonPin, INPUT_PULLUP);
  pinMode(grainButtonPin, INPUT_PULLUP);
  pinMode(sodaButtonLedPin, OUTPUT);
  pinMode(grainButtonLedPin, OUTPUT);
  sodaButton.attach(sodaButtonPin);
  sodaButton.interval(10);
  grainButton.attach(grainButtonPin);
  grainButton.interval(10);

  pinMode(pumpPin, OUTPUT);

  attachInterrupt(0, flowSensor, RISING); //flowsensor setup


  //blinkLed(3);
}

// Loop function
void loop()
{
  buttonStuff();
  flowStuff();
  ledStuff();
  serialStuff();

  //delay(1);

}

float fmap(float x, float in_min, float in_max, float out_min, float out_max)
{
  return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
}


