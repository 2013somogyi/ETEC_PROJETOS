#include <SoftwareSerial.h>


//Recebe e envia dados
SoftwareSerial bluetooth(2, 3);


//Motor Esquerdo
#define PINO_1 5
#define PINO_2 6

//Motor Direito
#define PINO_3 9
#define PINO_4 10

//Velocidade
const int VELOCIDADE = 200;

void setup()
{

  //Saídas
  pinMode(PINO_1, OUTPUT);
  pinMode(PINO_2, OUTPUT);
  pinMode(PINO_3, OUTPUT);
  pinMode(PINO_4, OUTPUT);

  //Comunicações
  Serial.begin(9600);
  bluetooth.begin(9600);

  Serial.println("Carrinho pronto!!!");

  //Função de parada
  parar();
}

//////////////////////////  DIREÇÕES  //////////////////////////

void parar()
{
  //Motor esquerdo
  analogWrite(PINO_1, 0);
  analogWrite(PINO_2, 0);
  
  //Motor direito
  analogWrite(PINO_3, 0);
  analogWrite(PINO_4, 0);

}

void frente()
{
  //Motor esquerdo
  analogWrite(PINO_1, VELOCIDADE);
  analogWrite(PINO_2, LOW);
  
  //Motor direito
  analogWrite(PINO_3, VELOCIDADE);
  analogWrite(PINO_4, LOW);

}

void tras()
{
  //Motor esquerdo
  analogWrite(PINO_1, LOW);
  analogWrite(PINO_2, VELOCIDADE);
  
  //Motor direito
  analogWrite(PINO_3, LOW);
  analogWrite(PINO_4, VELOCIDADE);

}

void direita()
{
  //Motor esquerdo
  analogWrite(PINO_1, VELOCIDADE);
  analogWrite(PINO_2, LOW);
  
  //Motor direito
  analogWrite(PINO_3, LOW);
  analogWrite(PINO_4, VELOCIDADE);

}

void esquerda()
{
  //Motor esquerdo
  analogWrite(PINO_1, LOW);
  analogWrite(PINO_2, VELOCIDADE);
  
  //Motor direito
  analogWrite(PINO_3, VELOCIDADE);
  analogWrite(PINO_4, LOW);

}

//////////////////////////  LOOP  //////////////////////////

void loop()
{
  if (bluetooth.available() > 0)
  {
    char comando = bluetooth.read();

    
    Serial.print("Comando recebido: ");
    Serial.println(comando);


//////////////////////////  MOVIMENTAÇÃO  //////////////////////////

    if (comando == 'F' || comando == 'f')
    {
      frente();
    }
    if (comando == 'B' || comando == 'b')
    {
      tras();
    }
    if (comando == 'L' || comando == 'l')
    {
      esquerda();
    }
    if (comando == 'R' || comando == 'r')
    {
      direita();
    }
    if (comando == 'S' || comando == 's')
    {
      parar();
    }
  }
}
