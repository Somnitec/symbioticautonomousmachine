//0=idle
//1=sodabutton pressed, waiting for izettle, sent serial 'a' to pc, pc sends back '3' when ack
//2=grain button pressed -> error
//3=(attempting to) pumping (potentially changing lightness towards fuller cup), sent 'b' to when succesful
//4=cup full, printing note, sends back '0' to ack

enum SAMstates
{
  idle,
  waitingForPayment,
  waitingForTapping,
  error,
  testing,
};

unsigned long ledTimer = 0;
float ledPos = 0;

SAMstates stateNow = idle;

void ledStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - ledTimer >= ledUpdateTime) {
    ledTimer = currentMillis;
    ledPos += ledBreathSpeed;
    if (ledPos > TWO_PI)ledPos -= TWO_PI;
    breath();

    //idle state
    if (stateNow == idle) {

      analogWrite(grainButtonLedPin, fmap(sin(ledPos + (3 * PI) / 3), -1, 1, 100, 255));
      analogWrite(sodaButtonLedPin, fmap(sin(ledPos + (4 * PI) / 3), -1, 1, 100, 255));

    }//waiting for payment state
    else if (stateNow == waitingForPayment) {

      analogWrite(sodaButtonLedPin, fmap(sin(ledPos * 4 + (6 * PI) / 3), -1, 1, 50, 255));

      analogWrite(grainButtonLedPin, 0);
    }//pumping state
    else if (stateNow == waitingForTapping) {

      analogWrite(sodaButtonLedPin, fmap(sin(ledPos * 15 + (6 * PI) / 3), -1, 1, 50, 255));

      analogWrite(grainButtonLedPin, 0);
    }//error state
    else if (stateNow == error) {
      analogWrite(sodaButtonLedPin, 255);
      analogWrite(grainButtonLedPin, 255);
      delay(blinkOnTime);
      analogWrite(sodaButtonLedPin, 0);
      analogWrite(grainButtonLedPin, 0);
      delay(blinkOffTime);
      //ledState = 0;
    }
    //test state
    else if (stateNow == testing) {
      int pins[] = {ledPinTop, ledPinMiddle, ledPinBottom, sodaButtonLedPin, grainButtonLedPin};
      for (int i = 0; i < 5; i++) {
        digitalWrite(pins[i], HIGH);
        delay(100);
        digitalWrite(pins[i], LOW);
      }
    }
  }
}

void breath() {
  analogWrite(ledPinTop, fmap(sin(ledPos), -1, 1, ledBreathMin, ledBreathMax));
  analogWrite(ledPinMiddle, fmap(sin(ledPos + PI / 3), -1, 1, ledBreathMin, ledBreathMax));
  analogWrite(ledPinBottom, fmap(sin(ledPos + (2 * PI) / 3), -1, 1, ledBreathMin, ledBreathMax));
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

void blinkGrain() {
  for (int i = 0; i < amountOfBlinks; i++) {
    analogWrite(sodaButtonLedPin, 0);
    analogWrite(grainButtonLedPin, 255);
    delay(blinkOnTime);
    analogWrite(grainButtonLedPin, 0);
    delay(blinkOffTime);
  }
}



