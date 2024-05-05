using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(numero: 848152, modelo: "Nokia", imei:"9838938", memoria: 128);
Console.WriteLine("Smartphone nokia..");
nokia.Ligar();
nokia.InstalarAplicativo("telegram");
Console.WriteLine("");


Console.WriteLine("Smartphone Iphone..");
Iphone iphone = new Iphone(numero: 85111, modelo: "Iphone", imei:"55115181", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Chromme");
Console.WriteLine("");