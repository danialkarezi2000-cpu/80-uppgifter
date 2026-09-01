/*Skriv en funktion som läser in antal timmar, 
beräknar och skriver ut hur mycket det blir omvandlat till minuter resp sekunder.*/
Console.Write("Ange antal timmar: ");
int timmer = int.Parse(Console.ReadLine()!);
int minuter = timmer * 60;
int sekunder = minuter * 60;
Console.WriteLine($"Det blir {minuter} minuter och {sekunder} sekunder.");