unsigned long flowTimer = 0;
void flowStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - flowTimer >= flowUpdateTime) {
    flowTimer = currentMillis;
    if (nowTapping) {
      if (waterFlow < tapAmount) {
        digitalWrite(pump1pin,HIGH);
        //cmdMessenger.sendCmd(kTapAmount, waterFlow);
      }else {
        digitalWrite(pump1pin,LOW);
        nowTapping = false;
        cmdMessenger.sendCmd(kTapSucceeded, "all done");
      }
    }


    /*
        if (ledState == 3) {
          digitalWrite(pump1pin, !digitalRead(pump1pin));
          if (waterFlow < liquidAmount)digitalWrite(pump1pin, HIGH);
          else {
            digitalWrite(pump1pin, LOW);
            ledState = 4;
            Serial.println("b");
          }


          //Serial.print("waterFlow: ");
          //Serial.print(waterFlow, 3);
          //Serial.println(" mL");
        }
        else digitalWrite(pump1pin, LOW);
    */
  }
}

void flowSensor()   //measure the quantity of square wave
{
  waterFlow += 1.0 / 5.880;
}
