unsigned long flowTimer = 0;
void flowStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - flowTimer >= flowUpdateTime) {
    flowTimer = currentMillis;

    digitalWrite(pumpPin, !digitalRead(pumpPin));
    

    Serial.print("waterFlow: ");
    Serial.print(waterFlow, 3);
    Serial.println(" mL");    
  }
}

void flowSensor()   //measure the quantity of square wave
{
  waterFlow += 1.0 / 5.880;
}
