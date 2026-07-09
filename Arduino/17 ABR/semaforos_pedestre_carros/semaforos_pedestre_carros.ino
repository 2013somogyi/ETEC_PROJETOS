//FARÓIS
const int f_red = 13;
const int f_yellow = 12;
const int f_green = 11;
const int p_red = 10;
const int p_green = 9;
const int botao = 4;

//TEMPO
int travessia = 5000;
int estado = 0;
long changeTime;


void setup()
{
 Serial.begin(9600);
  
  pinMode(f_red, OUTPUT);
  pinMode(f_yellow, OUTPUT);
  pinMode(f_green, OUTPUT);
  pinMode(p_red, OUTPUT);
  pinMode(p_green, OUTPUT);
  pinMode(botao, INPUT);
}

void loop()
{//COMUNICAÇÃO BOTÃO E FARÓIS
	int situacao = digitalRead(botao);
  
  	digitalWrite(f_green, HIGH);
 	digitalWrite(p_red, HIGH);
  
  	if (situacao == HIGH && (millis() - changeTime) > 5000)
    {
    	Serial.println("Segura ae pae, ta amarelo");
      	changeLights();
      	estado = 0;
    }
  	else 
    {
    	if (estado == 0)
        {
        	Serial.println("PEDESTRE NÃO PASSE! Tá vermelho");
            estado = 1;
        }
    }
}
  void changeLights()
  {//DESLIGA DE CARROS E LIGA DE PEDESTRE
  	digitalWrite(f_green, LOW);
    digitalWrite(f_yellow, HIGH);
    delay(2000);
    digitalWrite(f_yellow, LOW);
    digitalWrite(f_red, HIGH);
    delay(1000);
	digitalWrite(p_green, HIGH);
    digitalWrite(p_red, LOW);
    
    Serial.println("Passe pedestre! Tá verde");
    delay(travessia);
    
    //LÓGICA PISCA FARÓL VERDE DE PEDESTRE
    for (int x = 10; x >= 1; x--)
    {
    	Serial.println("Atenção! O farol de pedestres fechará em" + (String)x + "segundos");
      	digitalWrite (p_green, HIGH);
      	delay(500);
      	digitalWrite (p_green, LOW);
      	delay(1000);
    }
    
    digitalWrite (p_red, HIGH);
    delay(1000);
    digitalWrite (f_red, LOW);
    delay(1000);
    digitalWrite (f_green, HIGH);
    changeTime = millis();
  }
  