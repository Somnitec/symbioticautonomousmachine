//0=idle
//1=sodabutton pressed, waiting for izettle, sent serial 'a' to pc, pc sends back '3' when ack
//2=grain button pressed -> error
//3=(attempting to) pumping (potentially changing lightness towards fuller cup), sent 'b' to when succesful
//4=cup full, printing note, sends back '0' to ack


#define  idle 0
#define  waitingForPayment 1
#define  waitingForTapping 2
#define  error 3
#define  testing 4


unsigned long ledTimer = 0;
float ledPos = 0;


void ledStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - ledTimer >= ledUpdateTime) {
    if (nowTappingMilliseconds) {
      digitalWrite(led1pin, LOW);
      digitalWrite(led2pin, LOW);
      digitalWrite(led3pin, LOW);
    }
    else {
      ledTimer = currentMillis;
      ledPos += ledBreathSpeed;
      if (ledPos > TWO_PI)ledPos -= TWO_PI;
      breath();

      //idle state
      if (stateNow == idle) {

        analogWrite(buttonledpin, fmap(sin(ledPos + (4 * PI) / 3), -1, 1, 100, 255));

      }//waiting for payment state
      else if (stateNow == waitingForPayment) {

        analogWrite(buttonledpin, fmap(sin(ledPos * 4 + (6 * PI) / 3), -1, 1, 50, 255));

      }//pumping state
      else if (stateNow == waitingForTapping) {

        analogWrite(buttonledpin, fmap(sin(ledPos * 15 + (6 * PI) / 3), -1, 1, 50, 255));

      }//error state
      else if (stateNow == error) {
        analogWrite(buttonledpin, 255);
        delay(blinkOnTime);
        analogWrite(buttonledpin, 0);
        delay(blinkOffTime);
        //ledState = 0;
      }
      //test state
      else if (stateNow == testing) {
        int pins[] = {led1pin, led2pin, led3pin, buttonledpin};
        for (int i = 0; i < 4; i++) {
          digitalWrite(pins[i], HIGH);
          delay(100);
          digitalWrite(pins[i], LOW);
        }
      }
    }
  }
}

void breath() {
  analogWrite(led1pin, fmap(sin(ledPos), -1, 1, ledBreathMin, ledBreathMax));
  analogWrite(led2pin, fmap(sin(ledPos + PI / 3), -1, 1, ledBreathMin, ledBreathMax));
  analogWrite(led3pin, fmap(sin(ledPos + (2 * PI) / 3), -1, 1, ledBreathMin, ledBreathMax));
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



