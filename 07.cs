/*Skriv en funktion som beräknar vad du ska betala för en tank bensin. Indata är antal liter, pris per liter och eventuell rabatt i procent. Utdata är priset som du ska betala.*/
Console.Write("Ange antal liter: ");
double liter = double.Parse(Console.ReadLine()!);
Console.Write("Ange pris per liter; ");
double prisperliter = double.Parse(Console.ReadLine()!);
Console.Write("Ange eventuell rabatt i procent: ");
double rabatt = double.Parse(Console.ReadLine()!);
double prisutanrabatt = liter * prisperliter;
double prismedrabatt = prisutanrabatt - (prisutanrabatt * rabatt / 100.0);
Console.WriteLine($"priset utan rabatt är {prisutanrabatt} och priset med rabatt är {prismedrabatt}");