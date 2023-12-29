using DesafioPOO.Models;

Smartphone cel1 = new Nokia("4794899","65498494","Nokia 3",2048);
cel1.InstalarAplicativo("Google Play");
cel1.Ligar();
cel1.ReceberLigacao();

Console.WriteLine("==============================================");


Smartphone cel2 = new Iphone("1415641","179889","Iphone 2",4096);
cel2.InstalarAplicativo("App Store");
cel2.Ligar();
cel2.ReceberLigacao();
