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
  kCoinWait,
  kCoinAmount,
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
  cmdMessenger.attach(kPumpTap, OnPumpTap);
  cmdMessenger.attach(kSodaButtonPressed, OnSodaButtonPressed);
  cmdMessenger.attach(kTapAmount, OnTapAmount);
  cmdMessenger.attach(kSetLedBreathSpeed, OnSetLedBreathSpeed);
  cmdMessenger.attach(kSetLedBreathMax, OnSetLedBreathMax);
  cmdMessenger.attach(kSetLedBreathMin, OnSetLedBreathMin);
  cmdMessenger.attach(kSetLedState, OnSetLedState);
  cmdMessenger.attach(kPumpTapMilliseconds, OnPumpTapMilliseconds);
  cmdMessenger.attach(kCoinWait, OnCoinWait);
  //cmdMessenger.attach(kCoinAmount, OnCoinAmount);
}

// Called when a received command has no attached function
void OnUnknownCommand()
{
  cmdMessenger.sendCmd(kError, "Command without attached callback");
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
    cmdMessenger.sendCmd(kPumpTap, "turning on tap");
    waterFlow = 0;
    tapTimer = 0;
  } else if (value == false) {
    cmdMessenger.sendCmd(kPumpTap, waterFlow);
    cmdMessenger.sendCmd(kPumpTap, tapTimer);

  }

  digitalWrite(statusLedPin, value);
  digitalWrite(pump1pin, value);
}

void OnSodaButtonPressed()
{
  sodaButtonPress();
}


void OnTapAmount()
{
  waterFlow = 0;
  nowTapping = true;
  tapAmount = cmdMessenger.readInt16Arg();
  cmdMessenger.sendCmd(kTapAmount, "tapping now mL->");
  cmdMessenger.sendCmd(kTapAmount, tapAmount);
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
  waterFlow = 0;
  nowTappingMilliseconds = true;
  tapAmountMilliseconds = cmdMessenger.readInt16Arg();
  tapTimer = 0;
  cmdMessenger.sendCmd(kPumpTapMilliseconds, String("tapping now ms->").concat(tapAmountMilliseconds));
  //Serial.end();

  //  for (int fadeValue = 0 ; fadeValue <= 255; fadeValue += 1) {
  //    analogWrite(pump1pin, fadeValue);
  //    delay(1000 / 255);
  //  }
  digitalWrite(pump1pin, HIGH);
  delay(tapAmountMilliseconds ); //simplfied the shit
  //CPU_RESTART;
  digitalWrite(pump1pin, LOW);
  
  //  for (int fadeValue = 255 ; fadeValue >= 255; fadeValue -= 1) {
  //    analogWrite(pump1pin, fadeValue);
  //    delay(1000 / 255);
  //  }
  delay(1000);//maybe to allow the power to stabilize
  nowTappingMilliseconds = false;
  //Serial.end();
  //Serial.begin(115200);
  cmdMessenger.sendCmd(kTapSucceeded, "all done");
  cmdMessenger.sendCmd(kTestArduino, String("DONE!with this tapping"));

  coinValue = 0;
  cmdMessenger.sendCmd(kCoinAmount, coinValue);

  attachInterrupt(digitalPinToInterrupt(11), coinInterrupt , FALLING);


}

void OnCoinWait() {
  //coinValue = 0;
  int requestedValue = cmdMessenger.readInt16Arg();
  cmdMessenger.sendCmd(kTestArduino, String("I wait for coins : ").concat(requestedValue));
  while (coinValue < requestedValue) {
    //if (!coinEnabled) {
    //if (coinTimer > coinDebounce) {

    //coinEnabled = true;
    //attachInterrupt(digitalPinToInterrupt(11), coinInterrupt , FALLING);

    //}
    //}
    delay(1);
  }
  detachInterrupt(digitalPinToInterrupt(11));
  //cmdMessenger.sendCmd(kTestArduino, String("DONE! received coins : ").concat(coinValue));
  cmdMessenger.sendCmd(kCoinWait, coinValue);

  //coinValue = 0;
  //coinEnabled = true;
  //Serial.println(digitalRead(19));
  //delay(10);

}

