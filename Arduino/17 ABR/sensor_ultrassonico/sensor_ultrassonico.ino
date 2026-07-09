const int pinoTRIG = 12;
const int pinoECHO = 13;

int duracao;
int distancia;

void setup()
{
  	Serial.begin(9600);	
 	pinMode(pinoTRIG, OUTPUT);
  	pinMode(pinoECHO, INPUT);
}

void loop()
{
  digitalWrite(pinoTRIG, HIGH);
  delayMicroseconds(10);
  digitalWrite(pinoTRIG, LOW);
  
  duracao = pulseIn(pinoECHO, HIGH);
  distancia = duracao*0.017175;
  Serial.print(distancia);
  Serial.println("cm");
  delay(100);
}