using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Modelo Nokia", "123456789", "64GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine(); 

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("987654321", "Modelo Iphone", "987654321", "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram"); 
Console.WriteLine();