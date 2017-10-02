#include <CmdMessenger.h>  // CmdMessenger

CmdMessenger cmdMessenger = CmdMessenger(Serial);

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
  kPumpFlavor,
  kPump1stFerm,
  kPump2ndFerm,
  kPumpTap,
  kSodaButtonPressed,
  kGrainButtonPressed,
  kTapAmount,
  kTapSucceeded,
};

// Callbacks define on which received commands we take action
void attachCommandCallbacks()
{
  // Attach callback methods
  cmdMessenger.attach(OnUnknownCommand);
  cmdMessenger.attach(kReset, OnReset);
  cmdMessenger.attach(kTestArduino, OnTestArduino);
  cmdMessenger.attach(kTestTap, OnTestTap);
  cmdMessenger.attach(kTestLeds, OnTestLeds);
  cmdMessenger.attach(kPumpFlavor, OnPumpFlavor);
  cmdMessenger.attach(kPump1stFerm, OnPump1stFerm);
  cmdMessenger.attach(kPump2ndFerm, OnPump2ndFerm);
  cmdMessenger.attach(kPumpTap, OnPumpTap);
  cmdMessenger.attach(kSodaButtonPressed, OnSodaButtonPressed);
  cmdMessenger.attach(kGrainButtonPressed, OnGrainButtonPressed);
  cmdMessenger.attach(kTapAmount, OnTapAmount);
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

  cmdMessenger.sendCmd(kTestTap,"tapping now mL->");
  cmdMessenger.sendCmd(kTestTap,cmdMessenger.readInt16Arg());
  blinkLed(5);
  cmdMessenger.sendCmd(kTestTap, "tapping done");
}

void OnTestLeds()
{
  cmdMessenger.sendCmd(kTestLeds, cmdMessenger.readBoolArg());
}

void OnPumpFlavor()
{
  cmdMessenger.sendCmd(kPumpFlavor, cmdMessenger.readBoolArg());
}

void OnPump1stFerm()
{
  cmdMessenger.sendCmd(kPump1stFerm, cmdMessenger.readBoolArg());
}

void OnPump2ndFerm()
{
  cmdMessenger.sendCmd(kPump2ndFerm, cmdMessenger.readBoolArg());
}

void OnPumpTap()
{
  cmdMessenger.sendCmd(kPumpTap, cmdMessenger.readBoolArg());
}

void OnSodaButtonPressed()
{
  cmdMessenger.sendCmd(kSodaButtonPressed);
}

void OnGrainButtonPressed()
{
  cmdMessenger.sendCmd(kGrainButtonPressed);
}

void OnTapAmount()
{

  cmdMessenger.sendCmd(kTapAmount,"tapping now mL->");
  cmdMessenger.sendCmd(kTapAmount,cmdMessenger.readInt16Arg());
  blinkLed(7);
  cmdMessenger.sendCmd(kTapAmount, "tapping done");
  cmdMessenger.sendCmd(kTapSucceeded, "all done");
}


void setup()
{
  Serial.begin(115200);

  // Adds newline to every command
  //cmdMessenger.printLfCr();

  // Attach my application's user-defined callback methods
  attachCommandCallbacks();

  cmdMessenger.sendCmd(kAcknowledge, "Arduino has started!");

  pinMode(13, OUTPUT);
  blinkLed(3);
}

// Loop function
void loop()
{
  // Process incoming serial data, and perform callbacks
  cmdMessenger.feedinSerialData();
  delay(1);
  //cmdMessenger.sendCmd(kTest,random(100));

}

void blinkLed(int amount) {
  int blinkTime = 200;
  for (int i = 0; i < amount; i++ ) {
    digitalWrite(13, HIGH);
    delay(blinkTime);
    digitalWrite(13, LOW);
    delay(blinkTime);
  }

}

