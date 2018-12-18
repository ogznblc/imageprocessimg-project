void setup() {
  // put your setup code here, to run once:
 pinMode(13,OUTPUT);
 pinMode(12,OUTPUT);
 pinMode(11,OUTPUT);
 pinMode(7,OUTPUT);
 pinMode(6,OUTPUT);
 pinMode(5,OUTPUT);
pinMode(4,OUTPUT);
pinMode(3,OUTPUT);
pinMode(2,OUTPUT);


Serial.begin(9600);

}


void loop() 
{
  // put your main code here, to run repeatedly:
if (Serial.available()) // Serial Porta girdi değerinin olup olmadığını kontrol et.eger girdi varsa yazdır.
{
  int DATA= Serial.read();

     

   if(DATA=='a')
      {
          digitalWrite(13,LOW);
          digitalWrite(12,LOW);
          digitalWrite(11,LOW);
          digitalWrite(7,LOW);
          digitalWrite(6,LOW);
          digitalWrite(5,LOW);
          digitalWrite(4,LOW);
          digitalWrite(3,LOW);
          digitalWrite(2,HIGH); 
       
        }

    else if(DATA=='b')
      {   
          digitalWrite(13,LOW);
          digitalWrite(12,LOW);
          digitalWrite(11,LOW);
          digitalWrite(7,LOW);
          digitalWrite(6,LOW);
          digitalWrite(5,LOW);
          digitalWrite(4,LOW);
          digitalWrite(3,HIGH);
          digitalWrite(2,LOW); 
        }

    else if(DATA=='c')
      {
          digitalWrite(13,LOW);
          digitalWrite(12,LOW);
          digitalWrite(11,LOW);
          digitalWrite(7,LOW);
          digitalWrite(6,LOW);
          digitalWrite(5,LOW);
          digitalWrite(4,HIGH);
          digitalWrite(3,LOW);
          digitalWrite(2,LOW); 
        }
    else if(DATA=='d')
      {
          digitalWrite(13,LOW);
          digitalWrite(12,LOW);
          digitalWrite(11,LOW);
          digitalWrite(7,LOW);
          digitalWrite(6,LOW);
          digitalWrite(5,HIGH);
          digitalWrite(4,LOW);
          digitalWrite(3,LOW);
          digitalWrite(2,LOW); 
        }
     else if(DATA=='e')
      {
          digitalWrite(13,LOW);
          digitalWrite(12,LOW);
          digitalWrite(11,LOW);
          digitalWrite(7,LOW);
          digitalWrite(6,HIGH);
          digitalWrite(5,LOW);
          digitalWrite(4,LOW);
          digitalWrite(3,LOW);
          digitalWrite(2,LOW); 
        }
     else if(DATA=='f')
      {
          digitalWrite(13,LOW);
          digitalWrite(12,LOW);
          digitalWrite(11,LOW);
          digitalWrite(7,HIGH);
          digitalWrite(6,LOW);
          digitalWrite(5,LOW);
          digitalWrite(4,LOW);
          digitalWrite(3,LOW);
          digitalWrite(2,LOW); 
        }
     else if(DATA=='g')
      {
        digitalWrite(13,LOW);
          digitalWrite(12,LOW);
          digitalWrite(11,HIGH);
          digitalWrite(7,LOW);
          digitalWrite(6,LOW);
          digitalWrite(5,LOW);
          digitalWrite(4,LOW);
          digitalWrite(3,LOW);
          digitalWrite(2,LOW); 
        }
     else if(DATA=='h')
      {
          digitalWrite(13,LOW);
          digitalWrite(12,HIGH);
          digitalWrite(11,LOW);
          digitalWrite(7,LOW);
          digitalWrite(6,LOW);
          digitalWrite(5,LOW);
          digitalWrite(4,LOW);
          digitalWrite(3,LOW);
          digitalWrite(2,LOW); 
        }
     else if(DATA=='k')
      {
          digitalWrite(13,HIGH);
          digitalWrite(12,LOW);
          digitalWrite(11,LOW);
          digitalWrite(7,LOW);
          digitalWrite(6,LOW);
          digitalWrite(5,LOW);
          digitalWrite(4,LOW);
          digitalWrite(3,LOW);
          digitalWrite(2,LOW);
         
        }
  }
}
