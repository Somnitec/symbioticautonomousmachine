unsigned long ledTimer = 0;
float ledstate = 0;
void ledStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - ledTimer >= ledUpdateTime) {
    ledTimer = currentMillis;
    ledstate += ledBreathSpeed;
    if (ledstate > TWO_PI)ledstate -= TWO_PI;

    if (deviceState == 0) {
      analogWrite(ledPinTop, fmap(sin(ledstate), -1, 1, ledBreathMin, ledBreathMax));
      analogWrite(ledPinMiddle, fmap(sin(ledstate + PI / 3), -1, 1, ledBreathMin, ledBreathMax));
      analogWrite(ledPinBottom, fmap(sin(ledstate + (2 * PI) / 3), -1, 1, ledBreathMin, ledBreathMax));
    }
    else if (deviceState == 1) {
    }
    else if (deviceState == 1) {
    }
    else if (deviceState == 1) {
    }
    else if (deviceState == 1) {
    }
  }
}

