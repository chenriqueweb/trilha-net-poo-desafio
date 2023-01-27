using DesafioPOO.Models;

Console.Clear();

Console.WriteLine("Smartphone Noka:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "MOdelo 1", imei: "1212121212", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "MOdelo 1", imei: "1212121212", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");