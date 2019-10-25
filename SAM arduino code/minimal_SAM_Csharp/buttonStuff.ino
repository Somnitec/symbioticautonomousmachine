unsigned long buttonTimer = 0;
void buttonStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - buttonTimer >= buttonUpdateTime) {
    buttonTimer = currentMillis;

    sodaButton.update();

    if (sodaButton.rose()) {
      sodaButtonPress();
    }

  }
}

void sodaButtonPress() {
  cmdMessenger.sendCmd(kSodaButtonPressed);
}


