using DesafioPOO.Models;

Smartphone nokia = new Nokia("98765243","Nokia 2.4 Pro", "10009n46h5678", 64);

Smartphone iphone = new Iphone("96765243","Iphone 14", "17609n46h5678", 512);

Console.WriteLine("\nSmartphone Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("Smartphone Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

