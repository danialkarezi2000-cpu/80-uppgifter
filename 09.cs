/*Skriv en funktion där en cirkels radie läses in. Cirkelns diameter, 
omkrets och area skall beräknas och skrivas ut. (pi = 3.14).*/
Console.Write("Ange cirkelns radie: ");
double radie = double.Parse(Console.ReadLine()!);
double diameter = 2 * radie;
double omkrets = 2 * 3.14 * radie;
double area = 3.14 * radie * radie;
Console.WriteLine($"Cirkeln med radie {radie} har:");
Console.WriteLine($"Diameter: {diameter}");
Console.WriteLine($"Omkrets: {omkrets}");
Console.WriteLine($"Area: {area}");