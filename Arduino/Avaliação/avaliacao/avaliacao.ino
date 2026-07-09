//COMPONENTES
const int ledVermelhoC = 13;
const int ledAmareloC = 12;
const int ledVerdeC = 11;
const int ledVermelhoP = 10;
const int ledVerdeP = 9;
const int botao = 8;
const int buzzer = 7;
const int sensor = 0;

//TEMPO
int travessia = 5000;
int estado = 0;
long changeTime;

//BUZZER
const int tocar = 450;
const int tocarAgudo = 700;

void setup()
{
  Serial.begin(9600);
  
  pinMode(ledVermelhoC, OUTPUT);
  pinMode(ledAmareloC, OUTPUT);
  pinMode(ledVerdeC, OUTPUT);
  pinMode(ledVermelhoP, OUTPUT);
  pinMode(ledVerdeP, OUTPUT);

  pinMode(botao, INPUT);
  pinMode(buzzer, OUTPUT);
}

void loop()
{//COMUNICAÇÃO BOTÃO E FARÓIS
  int situacao = digitalRead(botao);

  digitalWrite(ledVerdeC, HIGH);
  digitalWrite(ledVermelhoP, HIGH);

  if (situacao == HIGH && (millis() - changeTime) > 5000)
  {
    Serial.println("Segura ae cego, ta amarelo");
    mudarFarois();
    estado = 0;
  }
  else 
  {
    if (estado == 0)
    {
      Serial.println("CEGO NÃO PASSE! Tá vermelho");
      estado = 1;
    }
  }

  //SENSOR
  int valorSensor = analogRead(sensor);

  apagarLeds();

  if (valorSensor <= 450)
  {
    for (int x = 10; x >= 1; x--)
    {
      Serial.println("Sinal amarelo intermitente");
      digitalWrite (ledAmareloC, HIGH);
      digitalWrite (ledVerdeP, HIGH);
      delay(500);
      digitalWrite (ledAmareloC, LOW);
      digitalWrite (ledVerdeP, LOW);
      delay(500);
    }
  }
}

void mudarFarois()
{//LÓGICA LIGA VERDE PEDESTRES
  digitalWrite(ledVerdeC, LOW);
  digitalWrite(ledAmareloC, HIGH);
  for (int x = 10; x >= 1; x--)
  {
    Serial.println("Se prepare! O farol de cegos vai abrir em" + (String)x + "segundos");
    digitalWrite (ledVermelhoP, HIGH);
    tone(buzzer, tocar, 500);
    delay(500);
    digitalWrite (ledVermelhoP, LOW);
    noTone(buzzer);
    delay(500);

  }
  digitalWrite(ledAmareloC, LOW);
  digitalWrite(ledVermelhoC, HIGH);
  delay(1000);
  digitalWrite(ledVerdeP, HIGH);
  digitalWrite(ledVermelhoP, LOW);

  Serial.println("Passe cego! Tá verde");
  delay(travessia);

  //LÓGICA LIGA VERDE CARROS
  for (int x = 10; x >= 1; x--)
  {
    Serial.println("Eita! O farol de cegos vai fechar em" + (String)x + "segundos");
    digitalWrite (ledVerdeP, HIGH);
    tone(buzzer, tocarAgudo, 500);
    delay(500);
    digitalWrite (ledVerdeP, LOW);
    noTone(buzzer);
    delay(500);
  }

  digitalWrite (ledVermelhoP, HIGH);
  delay(1000);
  digitalWrite (ledVermelhoC, LOW);
  delay(1000);
  digitalWrite (ledVerdeC, HIGH);
  changeTime = millis();

}


void apagarLeds()
{
	  digitalWrite(ledVermelhoC, LOW);
 	  digitalWrite(ledAmareloC, LOW);
    digitalWrite(ledVerdeC, LOW);
    digitalWrite(ledVermelhoP, LOW);
    digitalWrite(ledVerdeP, LOW);
}
  