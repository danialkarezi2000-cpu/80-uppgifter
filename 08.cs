/*Skriv en funktion som beräknar och skriver ut arean och omkretsen av en rektangel.
 Rektangelns sidor ska läsas in.*/
Console.Write("Ange rektangelns Längd: ");
double langd = double.Parse(Console.ReadLine()!);
Console.Write("Ange rektangelns Bredd: ");
double bredd = double.Parse(Console.ReadLine()!);
double area = langd * bredd;
double omkrets = 2 * (langd + bredd);
Console.WriteLine($"Arean av rektangeln är: {area}");
Console.WriteLine($"Omkretsen av rektangeln är: {omkrets}");