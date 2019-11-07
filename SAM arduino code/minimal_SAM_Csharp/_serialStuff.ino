// This is the list of recognized commands. These can be commands that can either be sent or received.
// In order to receive, attach a callback function to these events
enum
{
  kAcknowledge,
  kError,
  kReset,
  kTestArduino,
  kTestTap,
  kTestLeds,
  kPumpTap,
  kSodaButtonPressed,
  kGrainButtonPressed,
  kTapAmount,
  kTapSucceeded,
  kSetLedState,
  kSetLedBreathSpeed,
  kSetLedBreathMax,
  kSetLedBreathMin,
  kPumpTapMilliseconds,
};


void setupSerial() {
  Serial.begin(9600);
   /*
   while (!Serial) {
    ; // leonardo fix
   }
*/
  // Adds newline to every command
  //cmdMessenger.printLfCr();
  // Attach my application's user-defined callback methods
  attachCommandCallbacks();

  cmdMessenger.sendCmd(kAcknowledge, F("Arduino has started!"));
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
  cmdMessenger.attach(kPumpTap, OnPumpTap);
  //cmdMessenger.attach(kSetLedBreathSpeed, OnSetLedBreathSpeed);
  //cmdMessenger.attach(kSetLedBreathMax, OnSetLedBreathMax);
  //cmdMessenger.attach(kSetLedBreathMin, OnSetLedBreathMin);
  cmdMessenger.attach(kSetLedState, OnSetLedState);
  cmdMessenger.attach(kPumpTapMilliseconds, OnPumpTapMilliseconds);

}

// Called when a received command has no attached function
void OnUnknownCommand()
{
  cmdMessenger.sendCmd(kError, F("Command without attached callback"));
}

void OnReset()
{
  cmdMessenger.sendCmd(kReset);
  //return the states back to how they were
  //reset animation
}

void OnTestArduino()
{
  cmdMessenger.sendCmd(kTestArduino, String("I was send ").concat(String(cmdMessenger.readInt16Arg())));
  blinkLed(2);
}


void OnTestTap()
{

  cmdMessenger.sendCmd(kTestTap, F("test tap ->"));
  cmdMessenger.sendCmd(kTestTap, cmdMessenger.readInt16Arg());
  blinkLed(5);
  cmdMessenger.sendCmd(kTestTap, F("not implemented"));
}

void OnTestLeds()
{
  bool value = cmdMessenger.readBoolArg();
  if (value == true) {
    cmdMessenger.sendCmd(kTestLeds, F("led stest starting"));
    stateNow = testing;
  } else if (value == false) {
    cmdMessenger.sendCmd(kTestLeds, F("led stest stopped"));
    stateNow = idle;
  }

}

void OnPumpTap()
{
  bool value = cmdMessenger.readBoolArg();
  if (value == true) {
    cmdMessenger.sendCmd(kPumpTap, F("turning on tap"));
    //waterFlow = 0;
    tapTimer = 0;
  } else if (value == false) {
    //cmdMessenger.sendCmd(kPumpTap, waterFlow);
    cmdMessenger.sendCmd(kPumpTap, F("turning off tap"));
    cmdMessenger.sendCmd(kPumpTap, tapTimer);

  }

  digitalWrite(statusLedPin, value);
  digitalWrite(pumppin, value);
}

void OnSodaButtonPressed()
{

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
  //waterFlow = 0;
  nowTappingMilliseconds = true;
  tapAmountMilliseconds = cmdMessenger.readInt16Arg();

  cmdMessenger.sendCmd(kPumpTapMilliseconds, F("tapping now ms->"));
  cmdMessenger.sendCmd(kPumpTapMilliseconds, tapAmountMilliseconds);
  //delay(100);
  digitalWrite(pumppin, HIGH);
  //delay(3000);
  delay(tapAmountMilliseconds+100);//100 as a little buffer
  digitalWrite(pumppin, LOW);
  //delay(100);
  cmdMessenger.sendCmd(kPumpTapMilliseconds, F("done tapping"));
}
