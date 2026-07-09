int vermelho = 10;
int amarelo = 9;
int verde = 8;
int delaysemaforo = 500;

void setup(){
  pinMode(vermelho, OUTPUT);
  pinMode(amarelo, OUTPUT);
  pinMode(verde, OUTPUT);
}

void loop() {
  pinMode(vermelho, HIGH);
  delay(delaysemaforo);
  pinMode(vermelho, LOW);
  delay(500);

  pinMode(amarelo, HIGH);
  delay(delaysemaforo);
  pinMode(amarelo, LOW);
  delay(500);

  pinMode(verde, HIGH);
  delay(delaysemaforo);
  pinMode(verde, LOW);
  delay(500);
  }