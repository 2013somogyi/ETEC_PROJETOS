int v_botao = 8;
int v_ledRed = 10;

String v_situacao;

int v_estado;
  
void setup(){
  Serial.begin(9600);
  pinMode(v_botao, INPUT);
  pinMode(v_ledRed, OUTPUT);
}

void loop(){
  v_estado = digitalRead(v_botao);
  
  if (v_estado == HIGH){
  	digitalWrite(v_ledRed, HIGH);
    v_situacao = "LED ligado rapaz";
  }
  else{
    digitalWrite(v_ledRed, LOW);
    v_situacao = "Desligou visse";
  }
  Serial.println(v_situacao);
  delay(1);
}