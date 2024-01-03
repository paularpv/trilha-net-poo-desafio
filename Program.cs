using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99250760", modelo: "Modelo1", imei: "080099250760", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "Modelo2", imei: "0800123456789", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Amazon");