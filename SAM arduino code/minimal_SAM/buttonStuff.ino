unsigned long buttonTimer = 0;
void buttonStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - buttonTimer >= buttonUpdateTime) {
    buttonTimer = currentMillis;
    //digitalWrite(button1ledpin, digitalRead(button1pin));
    //digitalWrite(button2ledpin, digitalRead(button2pin));

    boolean button1state=!digitalRead(button1pin);
    boolean button2state=!digitalRead(button2pin);
    if(button1state==true&&(deviceState==0||deviceState==1)){
      deviceState=1;
      waterFlow=0;
      Serial.println('a');
    }
    if(button2state)deviceState=2;

  }
}

