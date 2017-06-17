unsigned long ledTimer = 0;
float ledstate = 0;
void ledStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - ledTimer >= ledUpdateTime) {
    ledTimer = currentMillis;
    ledstate += ledBreathSpeed;
    if (ledstate > TWO_PI)ledstate -= TWO_PI;

    if (deviceState == 0) {
      breath();
      analogWrite(button2ledpin, fmap(sin(ledstate + (3 * PI) / 3), -1, 1, 100, 255));
      analogWrite(button1ledpin, fmap(sin(ledstate + (4 * PI) / 3), -1, 1, 100, 255));

    }
    else if (deviceState == 1) {
      breath();
      analogWrite(button1ledpin, fmap(sin(ledstate * 4 + (6 * PI) / 3), -1, 1, 50, 255));
    }
    else if (deviceState == 2) {
      for (int i = 0; i < amountOfBlinks; i++) {
        analogWrite(ledPinTop, blinkBrightness);
        analogWrite(ledPinMiddle, blinkBrightness);
        analogWrite(ledPinBottom, blinkBrightness);
        analogWrite(button1ledpin, 0);
        analogWrite(button2ledpin, 255);
        delay(blinkOnTime);
        analogWrite(ledPinTop, 0);
        analogWrite(ledPinMiddle, 0);
        analogWrite(ledPinBottom, 0);
        analogWrite(button2ledpin, 0);
        delay(blinkOffTime);
      }
      deviceState = 0;
    }
    else if (deviceState == 3) {
      breath();

      analogWrite(button1ledpin, 10);
      analogWrite(button2ledpin, 0);
    }
    else if (deviceState == 4) {
      breath();

      analogWrite(button1ledpin, fmap(sin(ledstate * 4 + (10 * PI) / 3), -1, 1, 50, 255));
      analogWrite(button2ledpin, 0);
    }
  }
}

void breath() {
  analogWrite(ledPinTop, fmap(sin(ledstate), -1, 1, ledBreathMin, ledBreathMax));
  analogWrite(ledPinMiddle, fmap(sin(ledstate + PI / 3), -1, 1, ledBreathMin, ledBreathMax));
  analogWrite(ledPinBottom, fmap(sin(ledstate + (2 * PI) / 3), -1, 1, ledBreathMin, ledBreathMax));
}

