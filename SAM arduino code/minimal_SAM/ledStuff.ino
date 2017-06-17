unsigned long ledTimer = 0;
int ledstate = 0;
void ledStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - ledTimer >= ledUpdateTime) {
    ledTimer = currentMillis;
    if (ledstate % 3 == 0) {
      digitalWrite(ledPinTop, HIGH);
      digitalWrite(ledPinMiddle, LOW);
      digitalWrite(ledPinBottom, LOW);
    }
    else if (ledstate % 3 == 1) {
      digitalWrite(ledPinTop, LOW);
      digitalWrite(ledPinMiddle, HIGH);
      digitalWrite(ledPinBottom, LOW);
    }
    else if (ledstate % 3 == 2) {
      digitalWrite(ledPinTop, LOW);
      digitalWrite(ledPinMiddle, LOW);
      digitalWrite(ledPinBottom, HIGH);
    }
    ledstate++;
  }
}

