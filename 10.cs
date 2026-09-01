/*Sambandet mellan Fahrenheit och Celsius grader ges av formeln F=9C / 5 + 32.
Konstruera en funktion där en temperatur i Fahrenheit läses in och motsvarande temperatur i Celsius skrivs ut.*/
Console.Write("Ange temperatur i Fahrenheit: ");
double fahrenhit = double.Parse(Console.ReadLine()!);
double celsius = (fahrenhit - 32) * 5 / 9;
Console.WriteLine($"Temperaturen i Celsius är: {celsius}");
