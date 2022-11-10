using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "992158587", modelo: "Tijolão", imei: "555", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo cobrinha");

Console.WriteLine("\nIphone");
Smartphone iphone = new Iphone(numero: "992156647", modelo: "Iphone 11", imei: "111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");