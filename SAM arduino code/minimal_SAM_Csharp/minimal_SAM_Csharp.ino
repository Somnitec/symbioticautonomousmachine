#include <Bounce2.h>
#include <CmdMessenger.h>  // CmdMessenger

CmdMessenger cmdMessenger = CmdMessenger(Serial);

#define pump1pin 7
#define led1pin 5
#define led2pin 10
//#define mosfet3pin 11
//#define mosfet4pin 12
#define buttonpin 3
#define buttonledpin 6
#define buttonledvcc 4
#define cuppin 2

#define statusLedPin 13

#define  buttonUpdateTime 1//ms
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
void setup()
{
  //improving PWM speed
  //ideal speed is = ??


  setupSerial();

  pinMode(statusLedPin, OUTPUT);

  pinMode(led1pin, OUTPUT);
  pinMode(led2pin, OUTPUT);
  //pinMode(led3pin, OUTPUT);
  //pinMode(led4pin, OUTPUT);

  pinMode(buttonpin, INPUT_PULLUP);
  sodaButton.attach(buttonpin);
  sodaButton.interval(10);

  pinMode(buttonledvcc, OUTPUT);
  digitalWrite(buttonledvcc,HIGH);
  
  pinMode(pump1pin, OUTPUT);
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


