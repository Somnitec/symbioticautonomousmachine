unsigned long buttonTimer = 0;
void buttonStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - buttonTimer >= buttonUpdateTime) {
    buttonTimer = currentMillis;
    digitalWrite(button1ledpin, digitalRead(button1pin));
    digitalWrite(button2ledpin, digitalRead(button2pin));

  }
}

