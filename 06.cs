/*Skriv en funktion som beräknar funktionen ax3 + 7 och skriver ut resultatet. Variablerna a och x ska läsas in.*/
Console.Write("Ange värdet för a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Ange värdet för x: ");
int x = int.Parse(Console.ReadLine()!);
int resultat = a * (x * x * x) + 7;
Console.WriteLine($"Resultatet av funktionen ax3 + 7 är: {resultat}");