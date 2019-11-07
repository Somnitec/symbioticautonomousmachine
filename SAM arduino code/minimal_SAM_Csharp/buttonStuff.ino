unsigned long buttonTimer = 0;
void buttonStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - buttonTimer >= buttonUpdateTime) {
    buttonTimer = currentMillis;
    //digitalWrite(buttonledpin, digitalRead(buttonpin));//to test function
    //digitalWrite(grainButtonLedPin, digitalRead(grainButtonPin));//to test function

    sodaButton.update();

    if (sodaButton.fell()) {
<<<<<<< HEAD
      //sodaButtonPress();
      OnNEWbuttonPress();
=======
      sodaButtonPress();
>>>>>>> ada216cae6c3121b6b99362d141fb2c860ae561b
    }


    /*

      boolean button1state=!digitalRead(button1pin);
      boolean button2state=!digitalRead(button2pin);
      if(button1state==true&&(ledState==0||ledState==1)){
      //ledState=1;
      //waterFlow=0;
      cmdMessenger.sendCmd(kSodaButtonPressed);

      }
      if(button2state){
      ledState=2;
      cmdMessenger.sendCmd(kGrainButtonPressed);
      }
    */
  }
}

void sodaButtonPress() {
  cmdMessenger.sendCmd(kSodaButtonPressed);
}


