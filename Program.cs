using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(00)9 9999-9999", modelo: "NK-278", imei:"975473828", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "(01)88888-8888", modelo: "IPH-372", imei: "7834673", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");