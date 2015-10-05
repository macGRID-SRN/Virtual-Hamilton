// Example of using the PVision library for interaction with the Pixart sensor on a WiiMote
// This work was derived from Kako's excellent Japanese website
// http://www.kako.com/neta/2007-001/2007-001.html

// Steve Hobley 2009 - www.stephenhobley.com

#define PERIOD 200
#define HALF_PERIOD PERIOD/2
#include <Wire.h>
#include <PVision.h>
#include <IRremote.h>

PVision ircam;
IRsend irsend;
byte result;
byte value = 1;
void setup()
{
  Serial.begin(9600);
  ircam.init();
}

void loop()
{

  value++;
  if(value >= 6){
    value = 1;
  }
  irsend.sendNEC(value, 16);
  delay(HALF_PERIOD);

  Serial.println(value);
  result = ircam.read();

  
  if (result & BLOB1)
  {
    Serial.print("B1:");
    Serial.print(ircam.Blob1.X);
    Serial.print(":");
    Serial.print(ircam.Blob1.Y);
    Serial.print(":");
    Serial.println(ircam.Blob1.Size);
  }
  
  if (result & BLOB2)
  {
    Serial.print("B2:");
    Serial.print(ircam.Blob2.X);
    Serial.print(":");
    Serial.print(ircam.Blob2.Y);
    Serial.print(":");
    Serial.println(ircam.Blob2.Size);
  }
  if (result & BLOB3)
  {
    Serial.print("B3:");
    Serial.print(ircam.Blob3.X);
    Serial.print(":");
    Serial.print(ircam.Blob3.Y);
    Serial.print(":");
    Serial.println(ircam.Blob3.Size);
  }
  if (result & BLOB4)
  {
    Serial.print("B4:");
    Serial.print(ircam.Blob4.X);
    Serial.print(":");
    Serial.print(ircam.Blob4.Y);
    Serial.print(":");
    Serial.println(ircam.Blob4.Size);
  }

  // Short delay...
  delay(HALF_PERIOD);
}
