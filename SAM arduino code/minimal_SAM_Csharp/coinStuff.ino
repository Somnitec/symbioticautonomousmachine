int coinValue =0;


void coinStuff() {
  /*
    if (coinEnabled) {
      if (coinValue > 0) {
        sodaButtonPress();
        coinEnabled = false;
      }
    }
  */
  //Serial.println(digitalRead(19));
  //delay(10);
  //if (!coinEnabled) {
  //if (coinTimer > coinDebounce) {
  //cmdMessenger.sendCmd(kTestArduino, String("got coins without the button being pressed : ").concat(coinValue));

  //coinEnabled = true;
  //attachInterrupt(digitalPinToInterrupt(11), coinInterrupt , FALLING);
  //}
  //}
}

void coinInterrupt() {
  coinValue++;
  //Serial.println(coinValue);
  //cmdMessenger.sendCmd(kCoinAmount, coinValue);
  detachInterrupt(digitalPinToInterrupt(11));
  //delay(coinDebounce);
  attachInterrupt(digitalPinToInterrupt(11), coinInterrupt , FALLING);

  //
  //coinEnabled = false;
  //coinTimer = 0;
}

