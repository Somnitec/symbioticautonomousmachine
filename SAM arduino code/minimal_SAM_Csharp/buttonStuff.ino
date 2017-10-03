unsigned long buttonTimer = 0;
void buttonStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - buttonTimer >= buttonUpdateTime) {
    buttonTimer = currentMillis;
    //digitalWrite(sodaButtonLedPin, digitalRead(sodaButtonPin));//to test function
    //digitalWrite(grainButtonLedPin, digitalRead(grainButtonPin));//to test function

    sodaButton.update();
    grainButton.update();

    if(sodaButton.fell()){
      cmdMessenger.sendCmd(kSodaButtonPressed);
      //digitalWrite(sodaButtonLedPin,LOW);
    }
    if(grainButton.fell()){
      cmdMessenger.sendCmd(kGrainButtonPressed);
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

