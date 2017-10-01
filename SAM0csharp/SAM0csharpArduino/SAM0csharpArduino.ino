#include <CmdMessenger.h>  // CmdMessenger

CmdMessenger cmdMessenger = CmdMessenger(Serial);

// This is the list of recognized commands. These can be commands that can either be sent or received.
// In order to receive, attach a callback function to these events
enum
{
  kAcknowledge,
  kError,
  kTestArduino, 
  kTestTap,
};

// Callbacks define on which received commands we take action
void attachCommandCallbacks()
{
  // Attach callback methods
  cmdMessenger.attach(OnUnknownCommand);
  cmdMessenger.attach(kTestArduino, OnTestArduino);
  cmdMessenger.attach(kTestTap, OnTestTap);
}

// Called when a received command has no attached function
void OnUnknownCommand()
{
  cmdMessenger.sendCmd(kError, "Command without attached callback");
}

void OnTestArduino()
{
  cmdMessenger.sendCmd(kTestArduino, "testing this thing");
  cmdMessenger.sendCmd(kTestArduino,cmdMessenger.readInt16Arg());
  blinkLed(2);
}


void OnTestTap()
{
  cmdMessenger.sendCmd(kTestTap, "tapping now");
  cmdMessenger.sendCmd(kTestTap,cmdMessenger.readInt16Arg());
  blinkLed(5);
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
  blinkLed(1);
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

