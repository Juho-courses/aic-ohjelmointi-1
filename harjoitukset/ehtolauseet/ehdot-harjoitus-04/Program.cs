int luku = 201;

if (luku < 100)
{
    Console.WriteLine("arvo on aika pieni");
}
else if (luku == 100)
{
    Console.WriteLine("arvo on sata");
}
else if (luku > 100 && luku <= 200)
{
    Console.WriteLine("alkaa olla aika iso luku");
}
else
{
    Console.WriteLine("nyt ollaan isoissa luvuissa");
}