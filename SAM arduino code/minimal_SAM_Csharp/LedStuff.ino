//0=idle
//1=sodabutton pressed, waiting for izettle, sent serial 'a' to pc, pc sends back '3' when ack
//2=grain button pressed -> error
//3=(attempting to) pumping (potentially changing lightness towards fuller cup), sent 'b' to when succesful
//4=cup full, printing note, sends back '0' to ack

unsigned long ledTimer = 0;
float ledstate = 0;
void ledStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - ledTimer >= ledUpdateTime) {
    ledTimer = currentMillis;
    ledstate += ledBreathSpeed;
    if (ledstate > TWO_PI)ledstate -= TWO_PI;

    //idle state
    if (ledState == 0) {
      breath();
      analogWrite(grainButtonLedPin, fmap(sin(ledstate + (3 * PI) / 3), -1, 1, 100, 255));
      analogWrite(sodaButtonLedPin, fmap(sin(ledstate + (4 * PI) / 3), -1, 1, 100, 255));

    }//waiting for payment state
    else if (ledState == 1) {
      breath();
      analogWrite(sodaButtonLedPin, fmap(sin(ledstate * 4 + (6 * PI) / 3), -1, 1, 50, 255));
    }//error state
    else if (ledState == 2) {
      for (int i = 0; i < amountOfBlinks; i++) {
        //analogWrite(ledPinTop, blinkBrightness);
        //analogWrite(ledPinMiddle, blinkBrightness);
        //analogWrite(ledPinBottom, blinkBrightness);
        analogWrite(sodaButtonLedPin, 0);
        analogWrite(grainButtonLedPin, 255);
        delay(blinkOnTime);
        //analogWrite(ledPinTop, 0);
        //analogWrite(ledPinMiddle, 0);
        //analogWrite(ledPinBottom, 0);
        analogWrite(grainButtonLedPin, 0);
        delay(blinkOffTime);
      }
      ledState = 0;
    }//pumping state
    else if (ledState == 3) {
      breath();

      analogWrite(sodaButtonLedPin, 10);
      analogWrite(grainButtonLedPin, 0);
    }//printing state
    else if (ledState == 4) {
      breath();

      analogWrite(sodaButtonLedPin, fmap(sin(ledstate * 10 + (6 * PI) / 3), -1, 1, 50, 255));
      analogWrite(grainButtonLedPin, 0);
    }
  }
}

void breath() {
  analogWrite(ledPinTop, fmap(sin(ledstate), -1, 1, ledBreathMin, ledBreathMax));
  analogWrite(ledPinMiddle, fmap(sin(ledstate + PI / 3), -1, 1, ledBreathMin, ledBreathMax));
  analogWrite(ledPinBottom, fmap(sin(ledstate + (2 * PI) / 3), -1, 1, ledBreathMin, ledBreathMax));
}

void blinkLed(int amount) {
  int blinkTime = 200;
  for (int i = 0; i < amount; i++ ) {
    digitalWrite(statusLedPin, HIGH);
    delay(blinkTime);
    digitalWrite(statusLedPin, LOW);
    delay(blinkTime);
  }

}

