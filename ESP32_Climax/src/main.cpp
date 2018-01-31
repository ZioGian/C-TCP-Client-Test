#include <Arduino.h>
#include <LiquidCrystal_I2C.h>
#include <WiFi.h>
#include <pwm.h>

// settaggi della connessione WiFi
// #define ssid "CliMAX"            // inserite l'ssid della vostra rete
// #define password "CliMAX"        // password della vostra rete WiFi
const char *ssid = "CLImax";        // inserite l'ssid della vostra rete WiFi
const char *password = "climax0000";

IPAddress local_IP(10, 0, 0, 1);
IPAddress gateway(10, 0, 0, 1);
IPAddress subnet(255, 255, 255, 0);

//settaggi co comunicazionde del server
#define wellcome "Climax" // messaggio di benvenuto..
#define end_msg "$"       // fine della connessione client #define end_msg "\n\r"
#define port 123          // porta di ascolto del server

//settaggio piedini di comunicazione pannello LCD
#define SDA 23 //pin per la connessione del pannello LCD
#define SCL 22

// definizione pin di I/O utilizzati
#define LED_CLIENT 13 //led che si accende quando client connesso
#define LED_WIFI 12   //LED che si accende quando WiFi connessa
#define LED 27        // LED utente

//definizioni di ON/OFF
#define _on 1
#define _off 0

// variabili di appoggio
short cursor;
short riga_vuota; //utilizzato come booleano
short contatore = 0;
char buffer[10];

String line; //definizione di line come stringa

  // creazione della connessione con il pannello Lcd
LiquidCrystal_I2C Lcd(0x3F, 16, 2);
  //definiione caratteri speciali
  byte backslash[] = {B00000, B10000, B01000, B00100,
                      B00010, B00001, B00000, B00000};

// istanza del Server, creata sulla porta xyz
WiFiServer Server(port);

// definizione delle funzioni
void clock(int ritardo);

void setup()
{
  //Inizializzazione LCD
  Lcd.begin(SDA, SCL);
  Lcd.createChar(0, backslash);
  Lcd.clear();

  // inizializzazione dei pin (direzione e stato iniziale)
  pinMode(LED, OUTPUT);
  pinMode(LED_CLIENT, OUTPUT);
  pinMode(LED_WIFI, OUTPUT);

  digitalWrite(LED, _off);        // led spento
  digitalWrite(LED_CLIENT, _off); // led spento
  digitalWrite(LED_WIFI, _off);   // led spento

  // inizializzazione della porta seriale: baudarate 115200
  Serial.begin(115200);
  Lcd.clear();
  Lcd.print("Test connessione");
  Lcd.setCursor(0, 1);
  Lcd.print("TCP/IP + Lcd");
  delay(500);

  // connessione alla rete WiFi
  Lcd.clear();
  Lcd.print("Conn. WiFi:");

  WiFi.softAP(ssid, password);
  // WiFi.softAP("TESTWIFI");
  WiFi.softAPConfig(local_IP, gateway, subnet);

  Serial.println("Creazione  rete WiFi avvenuta con successo!");
  Serial.print("indirizzo IP: ");
  Serial.println(WiFi.softAPIP());


  while (!WiFi.softAPgetStationNum()) {
    Serial.println("In attesa di connessione... ");
    clock(500);
  }
  
  digitalWrite(LED_WIFI, _on);

  // scrivo nella seconda riga del pannello
  Lcd.setCursor(0, 1);
  Lcd.print(WiFi.softAPIP().toString());

  // avvio del Server, indicazione dell'attesa client sul pannello
  Server.begin();
  Lcd.home();
  Lcd.print("                ");
  Lcd.home();
  Lcd.print("Attesa CLIENT:");


  //avvio i pin PWM
  set_PWM();
}

void loop()
{
  // attesa della connessione da parte di un client
  WiFiClient client = Server.available();
  if (client)
  {
    digitalWrite(LED_CLIENT, _on);
    client.print(wellcome);
    // client.print(end_msg);

    while (client.connected())
    {
      // if  (client.available())
      
      if (client.available())
      {
        int tempo = millis();
        // reset del buffer stringa
        memset(buffer, 0, sizeof(buffer));
        // Read all the lines of the reply from Server and print them to Serial
        line = client.readStringUntil('\n');
        line.toCharArray(buffer, sizeof(line));

        // ricerca di comandi ON/OFF o vari...
        if (strstr(buffer, "led_on") > 0)
        {
          digitalWrite(LED, _on);
          client.print("OK: ON");
          // client.print(end_msg);
        }
        else if (strstr(buffer, "led_off") > 0)
        {
          digitalWrite(LED, _off);
          client.print("OK: OFF");
          // client.print(end_msg);
          }
        else
        {
          client.print("ERR!");
          // client.print(end_msg);
        }

      tempo = millis() - tempo;
      Serial.println(tempo);
      }
    }
    digitalWrite(LED_CLIENT, _off);
  }
  // pausa necessaria affinche' il browser possa ricevere i dati
  clock(500);
  // chiusura della connessione
  client.stop();
}

//definizione delle mie funzioni..
void clock(int ritardo = 500)
{
  char car[4] = {'|', '/', '-', 0};
  if (cursor++ >= 3)
    cursor = 0;
  //scrivo il carattere sull'LCD
  Lcd.write(car[cursor]);
  delay(ritardo);
  //cancello il carattere scritto
  Lcd.rightToLeft();
  Lcd.print(" ");
  Lcd.leftToRight();
}
