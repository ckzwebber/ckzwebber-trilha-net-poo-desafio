using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone Nokia = new Nokia(numero: "99999999", modelo: "Nokia 3310", imei: "1111111", memoria: 16);
Nokia.Ligar();
Nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero: "88888888", modelo: "Iphone 15", imei: "2222222", memoria: 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");