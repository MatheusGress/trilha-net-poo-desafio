using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "51994391482", modelo: "Nokia Delux", imei: "111111", memoria: 124);
nokia.Ligar();
nokia.InstalarAplicativo("\"WhatsApp\"");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "51982143690", modelo: "Iphone 13", imei: "99999", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("\"Telegram\"");