///Notas
int DO   = 262;
int RE   = 294;
int MI   = 330;
int FA   = 349;
int SOL  = 392;
int LA   = 440;
int SI   = 494;
int DO_2 = 523;

int buzzer = 8;

int melodia[] = {
    DO, RE, MI, FA, SOL, LA, SI, DO_2
  // 0   1   2   3   4    5   6   7
  };
  int tempo[] = {
  	300,300,300,300,300,300,300,300
  // 0   1   2   3   4   5   6   7
  };

void setup()
{
  pinMode(buzzer, OUTPUT);
}

void loop(){
  
    for (int i=0; i<9; i++)//Ou pode ser "i + 1"
  {
    tone(buzzer, melodia[i]);
    delay(tempo[i]);
  }

    for (int i=7; i>=0; i--)//Ou pode ser "i - 1"	
  {
    tone(buzzer, melodia[i]);
    delay(tempo[i]);
  }
}