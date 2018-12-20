


void coinStuff() {

  //Serial.println(digitalRead(19));
  //delay(10);
  if (!coinEnabled) {
    if (coinTimer > coinDebounce) {
      cmdMessenger.sendCmd(kTestArduino, String("got coins without the button being pressed : ").concat(coinValue));

      coinEnabled = true;
      attachInterrupt(digitalPinToInterrupt(11), coinInterrupt , FALLING);
    }
  }
}

void coinInterrupt() {
  coinValue++;
  //Serial.println(coinValue);
  detachInterrupt(digitalPinToInterrupt(11));
  coinEnabled = false;
  coinTimer = 0;
}

