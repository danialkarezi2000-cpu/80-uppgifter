/*En försäljare har delvis prestationslön. 
Han får 8000 kr per månad i grundlön och 9% av försäljningssumman. 
Skriv en funktion som beräknar lönesumman */
Console.Write("Ange försäljningssumman:");
double försäljningssumma = double.Parse(Console.ReadLine()!);
double grundlön = 8000;
double provision = försäljningssumma * 0.09;
double lönesumma = grundlön + provision;
Console.WriteLine($"Lönesumman är: {lönesumma} kr");