#include "FastLED.h"
#include <Bounce2.h>
#include <CmdMessenger.h>  // CmdMessenger

CRGB buttonled[1];

CmdMessenger cmdMessenger = CmdMessenger(Serial);

#define pumppin 7
#define led1pin 5
#define led2pin 10
#define buttonPin 3
#define buttonledpin 6
#define buttonledvcc 4
#define coinPin 2

#define statusLedPin 13

#define  buttonUpdateTime 1//ms
#define  ledUpdateTime 10//ms
#define  serialUpdateTime 1//ms

//idle animation
float ledBreathSpeed = 0.02;
int ledBreathMax = 50;
int ledBreathMin = 20;

//waiting animation

int coinDebounce = 5;
int coinTimer;
bool coinEnabled = true;
int coinValue = 0;

//error
#define blinkOnTime 100
#define blinkOffTime 120
#define amountOfBlinks 2

#define blinkBrightness 30

//pumping
boolean nowTapping = false;
boolean nowTappingMilliseconds = false;
int tapAmount = 0;
int tapAmountMilliseconds = 0;
unsigned long tapTimer = 0;

//printing


Bounce sodaButton = Bounce();
Bounce coinSwitch = Bounce();
void setup()
{
  //improving PWM speed
  //ideal speed is = ??


  setupSerial();

  pinMode(statusLedPin, OUTPUT);
  digitalWrite(statusLedPin, HIGH);

  pinMode(led1pin, OUTPUT);
  pinMode(led2pin, OUTPUT);

  //pinMode(buttonpin, INPUT_PULLUP);

  pinMode(coinPin, INPUT_PULLUP);
  //attachInterrupt(digitalPinToInterrupt(coinPin), coinInterrupt, FALLING);

  pinMode(buttonPin, INPUT_PULLUP);
  sodaButton.attach(buttonPin);
  sodaButton.interval(10);



  coinSwitch.attach(coinPin);
  coinSwitch.interval(100);

  pinMode(buttonledvcc, OUTPUT);
  digitalWrite(buttonledvcc, HIGH);

  FastLED.addLeds<NEOPIXEL, buttonledpin>(buttonled, 1).setCorrection(0xD4EBFF);

  pinMode(pumppin, OUTPUT);

  blinkLed(3);
}

// Loop function
void loop()
{
  buttonStuff();
  ledStuff();
  serialStuff();

  //delay(1);

}

float fmap(float x, float in_min, float in_max, float out_min, float out_max)
{
  return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
}


