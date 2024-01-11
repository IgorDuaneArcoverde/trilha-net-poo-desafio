using DesafioPOO.Models;

Console.WriteLine("Iniciando Smartphone...");
Smartphone nokia = new Nokia(numero:"98319385", modelo: "Nokia XS", imei: "111111111", memoria: 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("telegram");

Console.WriteLine("Iniciando Smartphone...");
Smartphone iphone = new Iphone(numero: "99939763", modelo: "Iphone XS", imei: "222222222", memoria: 2);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");


