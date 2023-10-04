double r;
do
{
    Console.Write("Kérem, adja meg a gömb sugarát (egész vagy tizedes szám formátumban : ");
    r = double.Parse(Console.ReadLine());

    if (r <= 0)
    {
        Console.WriteLine("Hiba: A sugarnak pozitívnak kell lennie.");
    }
}
while (r <= 0);

double felszin = 4 * Math.PI * r * r;
double terfogat = (4.0 / 3.0) * Math.PI * r * r * r;

Console.WriteLine($"A gömb felszíne: {felszin:.00}");
Console.WriteLine($"A gömb térfogata: {terfogat:.00}");

Console.ReadKey();