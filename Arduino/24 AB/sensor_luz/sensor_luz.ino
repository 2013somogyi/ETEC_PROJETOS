int valorSensor;

const int sensor = 0;
const int ldRed = 13;
const int ldYellow = 12;
const int ldGreen = 11;
const int farol = 8;


void setup()
{
  Serial.begin(9600);
  pinMode(ldRed, OUTPUT);
  pinMode(ldYellow, OUTPUT);
  pinMode(ldGreen, OUTPUT);
  pinMode(farol, OUTPUT);
}

void loop()
{
	int valorSensor = analogRead(sensor);
  
  	apagarLeds();
  
	Serial.println("=====================");  
  
  if (valorSensor < 450)
  {
  	digitalWrite(ldRed, HIGH);
    digitalWrite(farol, HIGH);

    Serial.println("Ambiente considerado ESCURO!");
  }
  else if (valorSensor >= 450 && valorSensor <= 900)
  {
  	digitalWrite(ldYellow, HIGH);
    Serial.println("Meio iluminado!");
  }
  else
  {
  	digitalWrite(ldGreen,HIGH);
    Serial.println("Muito claro!");
  }
  
  Serial.print("Valor lido pelo sensor: ");
  Serial.println(valorSensor);
  Serial.println("=====================");
  Serial.println();
  delay(1000);

  }

void apagarLeds()
{
  digitalWrite(ldRed, LOW);
  digitalWrite(ldYellow, LOW);
  digitalWrite(ldGreen, LOW);
  digitalWrite(farol, LOW);
}

