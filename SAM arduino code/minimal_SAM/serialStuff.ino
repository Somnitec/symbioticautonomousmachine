unsigned long serialTimer = 0;
void serialStuff() {
  unsigned long currentMillis = millis();
  if (currentMillis - serialTimer >= serialUpdateTime) {
    serialTimer = currentMillis;

    if (Serial.available() > 0) {
      byte incomingByte = Serial.read();
      if (incomingByte == '0')deviceState = 0;
      else if (incomingByte == '1')deviceState = 1;
      else if (incomingByte == '2')deviceState = 2;
      else if (incomingByte == '3')deviceState = 3;
      else if (incomingByte == '4')deviceState = 4; 
      //0=idle
      //1=sodabutton pressed, waiting for izettle, sent serial 'a' to pc, pc sends back '3' when ack
      //2=grain button pressed -> error
      //3=(attempting to) pumping (potentially changing lightness towards fuller cup), sent 'b' to when succesful
      //4=cup full, printing note, sends back '0' to ack
    }

  }
}
