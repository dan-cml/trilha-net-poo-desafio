using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarthphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Nokia", imei: "1111111", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("NBA");

Console.WriteLine("\n");

Console.WriteLine("Smarthphone Iphone:");
Smartphone iphone = new Iphone(numero: "4321", modelo: "Iphone", imei: "2222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");