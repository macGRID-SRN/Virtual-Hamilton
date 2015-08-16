/*
 * IRremote: IRsendDemo - demonstrates sending IR codes with IRsend
 * An IR LED must be connected to Arduino PWM pin 3.
 * Version 0.1 July, 2009
 * Copyright 2009 Ken Shirriff
 * http://arcfn.com
 */

#include <IRremote.h>

IRsend irsend;

void setup()
{
  Serial.begin(9600);
}

void loop() {
while(true){
      irsend.sendNEC(0x001, 16); // Sony TV power code
      Serial.println("1");
      delay(1500);
      irsend.sendNEC(0x002, 16); 
      Serial.println("2");
      delay(1500);
  }
}
