#include <LiquidCrystal.h>

const int rs = 12, en = 11, d4 = 5, d5 = 4, d6 = 3, d7 = 2;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);

int arg;

void setup() {
  lcd.begin(16,2);
  Serial.begin(9600);
}

void loop() {
  String serialData = Serial.readString();
  delay(100);
  if(serialData == "") {
    arg = 1;
  } else {
    arg = 0;
  }
  delay(100);
  switch(arg) {
    case 1:
      lcd.clear();
      break;
    default:
      lcd.setCursor(0,0);
      lcd.print(serialData);
      break;
  }
}
