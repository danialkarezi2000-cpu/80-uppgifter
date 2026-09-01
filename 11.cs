/*Skriv en funktion där två tal läses in och det första talet skrivs ut om det är störst.*/
Console.Write("Ange det första talet: ");
double tall1 = double.Parse(Console.ReadLine()!);
Console.Write("Ange det andra talet: ");
double tall2 = double.Parse(Console.ReadLine()!);
if (tall1 > tall2)
{
    Console.WriteLine($"Det första talet {tall1} är störst.");
}