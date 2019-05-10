// This is the list of recognized commands. These can be commands that can either be sent or received.
// In order to receive, attach a callback function to these events
enum
{
  kAcknowledge,
  kReset,
  kTestArduino,
  kTestTap,
  kTestLeds,
  kSetLedState,
  kSetLedBreathSpeed,
  kSetLedBreathMax,
  kSetLedBreathMin,
  kPumpTapMilliseconds,
  kTapSucceeded,
};


void setupSerial() {
  Serial.begin(115200);

  // Adds newline to every command
  //cmdMessenger.printLfCr();
  // Attach my application's user-defined callback methods
  attachCommandCallbacks();

  cmdMessenger.sendCmd(kAcknowledge, "Arduino has started!");
}

unsigned long serialTimer = 0;
void serialStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - serialTimer >= serialUpdateTime) {
    serialTimer = currentMillis;
    cmdMessenger.feedinSerialData();
  }
}
// Callbacks define on which received commands we take action
void attachCommandCallbacks()
{
  // Attach callback methods
  cmdMessenger.attach(OnUnknownCommand);
  cmdMessenger.attach(kReset, OnReset);
  cmdMessenger.attach(kTestArduino, OnTestArduino);
  cmdMessenger.attach(kTestTap, OnTestTap);
  cmdMessenger.attach(kTestLeds, OnTestLeds);
  cmdMessenger.attach(kSetLedBreathSpeed, OnSetLedBreathSpeed);
  cmdMessenger.attach(kSetLedBreathMax, OnSetLedBreathMax);
  cmdMessenger.attach(kSetLedBreathMin, OnSetLedBreathMin);
  cmdMessenger.attach(kSetLedState, OnSetLedState);
  cmdMessenger.attach(kPumpTapMilliseconds, OnPumpTapMilliseconds);
}

// Called when a received command has no attached function
void OnUnknownCommand()
{
  cmdMessenger.sendCmd(kAcknowledge, "Command without attached callback");
}

void OnReset()
{
//might be needed if things are instable
  
  //cmdMessenger.sendCmd(kReset);
  //return the states back to how they were
  //reset animation

  //delay(5000);
  //attachInterrupt(digitalPinToInterrupt(coinPin), coinInterrupt , FALLING);
}

void OnTestArduino()
{
  cmdMessenger.sendCmd(kTestArduino, String("I was send ").concat(String(cmdMessenger.readInt16Arg())));
  blinkLed(2);
}


void OnTestTap()
{

  cmdMessenger.sendCmd(kTestTap, "tapping now mL->");
  cmdMessenger.sendCmd(kTestTap, cmdMessenger.readInt16Arg());
  blinkLed(5);
  cmdMessenger.sendCmd(kTestTap, "tapping done");
}

void OnTestLeds()
{
  bool value = cmdMessenger.readBoolArg();
  if (value == true) {
    cmdMessenger.sendCmd(kTestLeds, "led stest starting");
    stateNow = testing;
  } else if (value == false) {
    cmdMessenger.sendCmd(kTestLeds, "led stest stopped");
    stateNow = idle;
  }

}

void OnPumpTap()
{
  bool value = cmdMessenger.readBoolArg();
  if (value == true) {
    cmdMessenger.sendCmd(kAcknowledge, "turning on tap");
    tapTimer = 0;
  } else if (value == false) {
    cmdMessenger.sendCmd(kAcknowledge, "turned off tap");


  }

  digitalWrite(statusLedPin, value);
  digitalWrite(pumppin, value);
}



void OnSetLedBreathSpeed()
{
  //String stringValue = cmdMessenger.readStringArg();
  //float value = stringValue.toFloat();
  float value = cmdMessenger.readFloatArg();
  cmdMessenger.sendCmd(kSetLedBreathSpeed, value);
  ledBreathSpeed = value ;
}
void OnSetLedBreathMax()
{
  int value = cmdMessenger.readInt16Arg();
  cmdMessenger.sendCmd(kSetLedBreathMax, value);
  ledBreathMax = value ;
}
void OnSetLedBreathMin()
{
  int value = cmdMessenger.readInt16Arg();
  cmdMessenger.sendCmd(kSetLedBreathMin, value);
  ledBreathMin = value ;
}
void OnSetLedState()
{
  int value = cmdMessenger.readInt16Arg();
  cmdMessenger.sendCmd(kSetLedState, value);
  stateNow = value ;
}

void OnPumpTapMilliseconds() {

  nowTappingMilliseconds = true;
  tapAmountMilliseconds = cmdMessenger.readInt16Arg();

  cmdMessenger.sendCmd(kPumpTapMilliseconds, "tapping now ms->");
  cmdMessenger.sendCmd(kPumpTapMilliseconds, tapAmountMilliseconds);
  digitalWrite(pumppin, HIGH);
  delay(tapAmountMilliseconds);
  analogWrite(pumppin, 0);
  cmdMessenger.sendCmd(kTapSucceeded, "done tapping");
}
