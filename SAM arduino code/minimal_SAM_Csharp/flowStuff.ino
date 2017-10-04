unsigned long flowTimer = 0;
void flowStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - flowTimer >= flowUpdateTime) {
    flowTimer = currentMillis;
    if (nowTapping) {
      if (waterFlow < tapAmount) {
        digitalWrite(pumpPin,HIGH);
        //cmdMessenger.sendCmd(kTapAmount, waterFlow);
      }else {
        digitalWrite(pumpPin,LOW);
        nowTapping = false;
        cmdMessenger.sendCmd(kTapSucceeded, "all done");
      }
    }


    /*
        if (ledState == 3) {
          digitalWrite(pumpPin, !digitalRead(pumpPin));
          if (waterFlow < liquidAmount)digitalWrite(pumpPin, HIGH);
          else {
            digitalWrite(pumpPin, LOW);
            ledState = 4;
            Serial.println("b");
          }


          //Serial.print("waterFlow: ");
          //Serial.print(waterFlow, 3);
          //Serial.println(" mL");
        }
        else digitalWrite(pumpPin, LOW);
    */
  }
}

void flowSensor()   //measure the quantity of square wave
{
  waterFlow += 1.0 / 5.880;
}
