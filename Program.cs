double sugar, magassag;
do
{
    Console.Write("Kérem, adja meg a henger sugarát (egész vagy tizedes szám formátumban): ");
    sugar = double.Parse(Console.ReadLine());

    if (sugar <= 0)
    {
        Console.WriteLine("Hiba: A sugarnak pozitívnak kell lennie.");
    }
}
while (sugar <= 0);

do
{
    Console.Write("Kérem, adja meg a henger magasságát (egész vagy tizedes szám formátumban): ");
    magassag = double.Parse(Console.ReadLine());

    if (magassag <= 0)
    {
        Console.WriteLine("Hiba: A magasságnak pozitívnak kell lennie.");
    }
}
while (magassag <= 0);

double felszin = 2 * Math.PI * sugar * (sugar + magassag);
double terfogat = Math.PI * sugar * sugar * magassag;

Console.WriteLine($"A henger felszíne: {felszin:.00}");
Console.WriteLine($"A henger térfogata: {terfogat:.00}");

Console.ReadKey();