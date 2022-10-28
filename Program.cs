using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Testes realizados.
Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("123456789", "XR", "00000000", 128);
iphone.Ligar();
iphone.InstalarAplicativo("BeReal");
iphone.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("987654321", "5.4", "99999999", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");
nokia.ReceberLigacao();