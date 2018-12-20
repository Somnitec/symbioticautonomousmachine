#include <Bounce2.h>
#include <CmdMessenger.h>  // CmdMessenger

CmdMessenger cmdMessenger = CmdMessenger(Serial);

#define pump1pin 0
#define pump2pin 1
#define pump3pin 2
#define led1pin 3
#define led2pin 4
#define led3pin 6
#define stirmotorpin 9
#define sugarmotorpin 10
#define buttonpin 26
#define buttonledpin 16
#define flowsensor1pin 15
#define flowsensor2pin 14
#define weightclock 5
#define weight1pin 7
#define weight2pin 8
#define coinPin 11 //last minute hack change
#define weight4pin 12
#define servo1pin 23
#define servo2pin 22
#define servo3pin 20
#define servo4pin 17
#define temp1pin 18
#define temp2pin 19
#define pHpin 21
#define cuppin 25
#define gaspin 24

#define statusLedPin 13

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

boolean nowTappingMilliseconds = false;
int tapAmountMilliseconds = 0;
elapsedMillis tapTimer = 0;


int coinDebounce = 100;
elapsedMillis coinTimer;
bool coinEnabled = true;
int coinValue = 0;

//printing


Bounce sodaButton = Bounce();
void setup()
{
  //improving PWM speed
  //ideal speed is = ??




  setupSerial();

  pinMode(statusLedPin, OUTPUT);
  digitalWrite(statusLedPin, HIGH);

  pinMode(coinPin, INPUT_PULLUP);
   attachInterrupt(digitalPinToInterrupt(coinPin), coinInterrupt, FALLING);


  pinMode(led1pin, OUTPUT);
  pinMode(led2pin, OUTPUT);
  pinMode(led3pin, OUTPUT);

  pinMode(buttonpin, INPUT_PULLUP);
  pinMode(buttonledpin, OUTPUT);
  sodaButton.attach(buttonpin);
  sodaButton.interval(10);

  pinMode(pump1pin, OUTPUT);

  attachInterrupt(flowsensor1pin, flowSensor, RISING); //flowsensor setup

  pinMode(servo1pin, OUTPUT);
  pinMode( servo2pin, OUTPUT);
  pinMode( servo3pin, OUTPUT);
  pinMode( servo4pin, OUTPUT);
  digitalWrite(servo1pin, LOW);
  digitalWrite( servo2pin, LOW);
  digitalWrite( servo3pin, LOW);
  digitalWrite( servo4pin, LOW);

  //blinkLed(3);
}

// Loop function
void loop()
{
  buttonStuff();
  coinStuff();
  flowStuff();
  ledStuff();
  serialStuff();

  //delay(1);

}

float fmap(float x, float in_min, float in_max, float out_min, float out_max)
{
  return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
}


