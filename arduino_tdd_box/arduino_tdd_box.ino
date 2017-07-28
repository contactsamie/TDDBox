void setup()
{
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  digitalWrite(13, HIGH);
  digitalWrite(12, HIGH);
  digitalWrite(11, HIGH);
}

int passedCount = 0;

void loop()
{
  String data = Serial.readString();//Read the serial buffer as a string

  if (data.indexOf("RED") != -1)
  {
    digitalWrite(13, LOW);
    digitalWrite(12, HIGH);
    digitalWrite(11, HIGH);
    passedCount = 0;
  }

  if (data.indexOf("GREEN") != -1)
  {
    digitalWrite(13, HIGH);
    digitalWrite(12, LOW);
    digitalWrite(11, HIGH);
    passedCount++;
  }

  if (data.indexOf("YELLOW") != -1)
  {
    digitalWrite(13, HIGH);
    digitalWrite(12, HIGH);
    digitalWrite(11, LOW);
    passedCount++;
  }
  if (data.indexOf("OFF") != -1)
  {
    digitalWrite(13, HIGH);
    digitalWrite(12, HIGH);
    digitalWrite(11, HIGH);
    passedCount = 0;
  }

  if (passedCount > 1) {
    digitalWrite(11, LOW);
  } else
  {
    digitalWrite(11, HIGH);
  }
}
