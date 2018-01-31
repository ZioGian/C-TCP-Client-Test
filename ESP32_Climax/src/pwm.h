//definisco i PIN che userò
//informazioni per lo schema
#define IO_DX_FW 17 //motore destro avanti
#define IO_DX_RW 4 //motore destro retromarcia
#define IO_SX_FW 32  //motore sinistro avanti
#define IO_SX_RW 25  //motore destro retromarcia

//definisco i canali che userò per i PWM
//informazioni per il software
#define DX_FW 0 //motore destro avanti
#define DX_RW 1 //motore destro retromarcia
#define SX_FW 2 //motore sinistro avanti
#define SX_RW 3 //motore sinistro retromarcia

//definisco precisione dei PWM (tutti e 4 uguali)
#define PWM_TIMER_BIT 10 //precisione a 10 bit, 0->1023

//definisco la frequenza di lavoro
#define PWM_FREQ 1000 //1KHz

//definisco le funzioni usate
void set_PWM() {
    //definizione delle frequenze operative e dei canali
    ledcSetup(DX_FW, PWM_FREQ, PWM_TIMER_BIT);
    ledcSetup(DX_RW, PWM_FREQ, PWM_TIMER_BIT);
    ledcSetup(SX_FW, PWM_FREQ, PWM_TIMER_BIT);
    ledcSetup(SX_RW, PWM_FREQ, PWM_TIMER_BIT);

    //associazione canale/piedino
    ledcAttachPin(IO_DX_FW, DX_FW);
    ledcAttachPin(IO_DX_RW, DX_RW);
    ledcAttachPin(IO_SX_FW, SX_FW);
    ledcAttachPin(IO_SX_RW, SX_RW);
}

void motor_DX(int speed){    
    Serial.println(speed);
    if (speed >= 50) {
        ledcWrite(DX_RW, 0);
        //rimappo il valore da 50-100 a 0-1024
        speed = map(speed, 50, 100, 0, 1024);
        ledcWrite(DX_FW, speed);
        return;
    } else {
        ledcWrite(DX_FW, 0);
        //rimappo il valore da 50-0 a 0-1024
        speed = map(speed, 50, 0, 0, 1024);
        ledcWrite(DX_RW, speed);
        return;
    }
}

void motor_SX(int speed){
    Serial.println(speed);
    if (speed >= 50) {
        ledcWrite(SX_RW, 0);
        //rimappo il valore da 50-100 a 0-1024
        speed = map(speed, 50, 100, 0, 1024);
        ledcWrite(SX_FW, speed);
        return;
    } else {
        ledcWrite(SX_FW, 0);
        //rimappo il valore da 50-0 a 0-1024
        speed = map(speed, 50, 0, 0, 1024);
        ledcWrite(SX_RW, speed);
        return;
    }
}
void motor_DX_off(){
    ledcWrite(DX_FW, 0);
    ledcWrite(DX_RW, 0);
}

void motor_SX_off(){
    ledcWrite(SX_FW, 0);
    ledcWrite(SX_RW, 0);
}


/*
//nel main...
#include <Arduino.h>
#include <mio.h>

int gian = 100;

int pippo(int&);

void setup()
{
    Serial.begin(115200);
}

void loop()
{
    gian = millis();
    pippo(gian);
    _del;
}
//nel file .h
#define _del delay(500);

int pippo(int &gian)
{
    Serial.print("Valore: ");
    Serial.print(gian);
    Serial.println(" ");
    gian++;
    return gian;
}
*/
