using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:";
Smartphone nokia = new Nokia ( numero :  "4002", modelo: " Modelo 2" , imei: "13");
nokia.Ligar();
nokia,InstalarAplicativo("Whatsapp");

Console.writeLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new iphone( numero : "1046", modelo: "Modelo 5" , imei: "14");
iphone.ReceberLigação();
iphone.InstalarAplicativo("Telegram");
