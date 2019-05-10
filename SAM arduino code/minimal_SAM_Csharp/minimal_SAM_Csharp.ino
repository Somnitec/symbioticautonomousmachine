
#include <CmdMessenger.h>  // CmdMessenger


CmdMessenger cmdMessenger = CmdMessenger(Serial);

#define pumppin A0
#define led1pin 9
#define led2pin 10
#define led3pin 11

#define statusLedPin 13

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
boolean nowTappingMilliseconds = false;
int tapAmountMilliseconds = 0;
unsigned long tapTimer = 0;

//printing


void setup()
{
  //improving PWM speed
  //ideal speed is = ??


  setupSerial();

  pinMode(statusLedPin, OUTPUT);
  digitalWrite(statusLedPin, HIGH);

  pinMode(led1pin, OUTPUT);
  pinMode(led2pin, OUTPUT);
  pinMode(led3pin, OUTPUT);
 pinMode(pumppin, OUTPUT);

  blinkLed(3);
}

// Loop function
void loop()
{
  ledStuff();
  serialStuff();

  //delay(1);

}

float fmap(float x, float in_min, float in_max, float out_min, float out_max)
{
  return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
}
