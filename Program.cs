using DesafioPOO.Models;

Nokia nokia = new Nokia("(11)98733-7242", "Nokia 12 Pro", "852013-63-223531-7", 8);

Console.WriteLine("\n============ Nokia ============");
nokia.Exibir();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

// ==========================================================

Thread.Sleep(2000);

// ==========================================================

Iphone iphone = new Iphone("(11)98123-3275", "Iphone 13 Ultra Max", "492742-14-592414-2", 12);

Console.WriteLine("\n============ Iphone ============");
iphone.Exibir();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nQualquer tecla para finalizar:");
Console.ReadLine();

