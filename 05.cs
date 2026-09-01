/*Läs in ett heltal motsvarande svenska kronor och skriv ut motsvarande värde i pund respektive dollar. Antag att kursen är : 1 dollar = 6 kr, 1 pund = 10 kr.*/
Console.Write("Ange antal kronor: ");
int kronor = int.Parse(Console.ReadLine()!);
double dollar = kronor / 6.0;
double pund = kronor / 10.0;
Console.WriteLine($"det blir {dollar} dollar och {pund} pund.");

