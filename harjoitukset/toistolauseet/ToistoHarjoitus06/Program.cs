Console.Write("anna sana: ");
string sana = Console.ReadLine().ToLower();

int vokaalien_maara = 0;
// a e i o u y ä ö
foreach (var merkki in sana)
{
    if (merkki == 'a')
    {
        vokaalien_maara++;
    }
    else if (merkki == 'e')
    {
        vokaalien_maara++;
    }
    else if (merkki == 'i')
    {
        vokaalien_maara++;
    }
    else if (merkki == 'o')
    {
        vokaalien_maara++;
    }
    else if (merkki == 'u')
    {
        vokaalien_maara++;
    }
    else if (merkki == 'y')
    {
        vokaalien_maara++;
    }
    else if (merkki == 'ä')
    {
        vokaalien_maara++;
    }
    else if (merkki == 'ö')
    {
        vokaalien_maara++;
    }
}

Console.WriteLine($"Syötteestä löytyi {vokaalien_maara} vokaalia.");