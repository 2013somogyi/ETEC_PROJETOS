/* We Wish You a Merry Christmas com 3 LEDs (8, 9, 10)
  Adaptado para incluir dois padrões de pisca-pisca.
*/

#define NOTE_C5  523
#define NOTE_D5  587
#define NOTE_E5  659
#define NOTE_F5  698
#define NOTE_G5  784
#define NOTE_A5  880
#define NOTE_AS5 932
#define NOTE_C6  1047
#define REST      0

// Pinos dos LEDs e Buzzer
int buzzer = 7;
int ledPins[] = {8, 9, 10}; 
int numLeds = 3;

int tempo = 140;

int melody[] = {
  NOTE_C5,4, NOTE_F5,4, NOTE_F5,8, NOTE_G5,8, NOTE_F5,8, NOTE_E5,8,
  NOTE_D5,4, NOTE_D5,4, NOTE_D5,4, NOTE_G5,4, NOTE_G5,8, NOTE_A5,8, NOTE_G5,8, NOTE_F5,8,
  NOTE_E5,4, NOTE_C5,4, NOTE_C5,4, NOTE_A5,4, NOTE_A5,8, NOTE_AS5,8, NOTE_A5,8, NOTE_G5,8,
  NOTE_F5,4, NOTE_D5,4, NOTE_C5,8, NOTE_C5,8, NOTE_D5,4, NOTE_G5,4, NOTE_E5,4,
  NOTE_F5,2, NOTE_C5,4, NOTE_F5,4, NOTE_F5,8, NOTE_G5,8, NOTE_F5,8, NOTE_E5,8,
  NOTE_D5,4, NOTE_D5,4, NOTE_D5,4, NOTE_G5,4, NOTE_G5,8, NOTE_A5,8, NOTE_G5,8, NOTE_F5,8,
  NOTE_E5,4, NOTE_C5,4, NOTE_C5,4, NOTE_A5,4, NOTE_A5,8, NOTE_AS5,8, NOTE_A5,8, NOTE_G5,8,
  NOTE_F5,4, NOTE_D5,4, NOTE_C5,8, NOTE_C5,8, NOTE_D5,4, NOTE_G5,4, NOTE_E5,4,
  NOTE_F5,2, NOTE_C5,4, NOTE_F5,4, NOTE_F5,4, NOTE_F5,4, NOTE_E5,2, NOTE_E5,4,
  NOTE_F5,4, NOTE_E5,4, NOTE_D5,4, NOTE_C5,2, NOTE_A5,4, NOTE_AS5,4, NOTE_A5,4, NOTE_G5,4,
  NOTE_C6,4, NOTE_C5,4, NOTE_C5,8, NOTE_C5,8, NOTE_D5,4, NOTE_G5,4, NOTE_E5,4, NOTE_F5,2, REST,4
};

int notes = sizeof(melody) / sizeof(melody[0]) / 2;
int wholenote = (60000 * 4) / tempo;
int divider = 0, noteDuration = 0;

void setup() {
  pinMode(buzzer, OUTPUT);
  for (int i = 0; i < numLeds; i++) {
    pinMode(ledPins[i], OUTPUT);
  }

  for (int thisNote = 0; thisNote < notes * 2; thisNote = thisNote + 2) {
    divider = melody[thisNote + 1];
    if (divider > 0) {
      noteDuration = (wholenote) / divider;
    } else if (divider < 0) {
      noteDuration = (wholenote) / abs(divider);
      noteDuration *= 1.5;
    }

    // Aciona o padrão de LED baseado na posição da música
    animarLeds(thisNote / 2);

    tone(buzzer, melody[thisNote], noteDuration * 0.9);
    delay(noteDuration);
    noTone(buzzer);
    
    // Desliga LEDs rapidamente entre as notas
    desligarLeds();
  }
}

void loop() {
  // A música toca apenas uma vez no setup
}

void desligarLeds() {
  for(int i=0; i<numLeds; i++) digitalWrite(ledPins[i], LOW);
}

void animarLeds(int indiceNota) {
  desligarLeds();

  // PADRÃO 1: Sequencial (Até a nota 30)
  if (indiceNota < 30) {
    digitalWrite(ledPins[indiceNota % numLeds], HIGH);
  } 
  // PADRÃO 2: Alternado (Da nota 30 em diante)
  else {
    if (indiceNota % 2 == 0) {
      digitalWrite(ledPins[0], HIGH);
      digitalWrite(ledPins[2], HIGH);
    } else {
      digitalWrite(ledPins[1], HIGH);
    }
  }
}