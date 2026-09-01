/*Skriv en funktion som läser in tre tal och beräknar och skriver ut summan samt medelvärdet av de tre talen.*/
Console.Write("Ange första talet: ");
int tall = int.Parse(Console.ReadLine()!);
Console.Write("Ange andra talet: ");
int tal2 = int.Parse(Console.ReadLine()!);
Console.Write("Ange tredje talet: ");
int tal3 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Summan av de tre talen är: {tall + tal2 + tal3}");
Double medelvarde = (tall + tal2 + tal3) / 3.0;
Console.WriteLine($"Medelvärdet av de tre talen är: {medelvarde}");