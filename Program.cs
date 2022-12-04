using DesafioPOO.Models;


Nokia C1 = new Nokia(numero: "21899213801", modelo: "C30", imei: "1823ASRS213", memoria: 2);
Console.WriteLine("Smartphone Nokia, Numero: " + C1.Numero);
C1.Ligar();
C1.ReceberLigacao();
C1.InstalarAplicativo("WhatsApp \n");



Iphone F1 = new Iphone(numero: "21392830101", modelo: "8", imei: "221232ASPC34", memoria: 4);
Console.WriteLine("Smartphone Iphone, Numero: " + F1.Numero);
F1.Ligar();
F1.ReceberLigacao();
F1.InstalarAplicativo("Instagram");