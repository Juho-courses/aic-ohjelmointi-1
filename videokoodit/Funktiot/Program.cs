// Kirjoita ohjelma, joka tulostaa sanan "moi" 5 kertaa peräkkäin,
// sanan "koulu" 2 kertaa peräkkäin
// ja sanan "SAMK" 15 kertaa peräkkäin.
// Erota eri sanojen tulosteet rivivaihdolla.

string PalautaSanaNKertaa(string sana, int n)
{
    string paluuarvo = "";
    for (int i = 0; i < n; i++)
    {
        paluuarvo += sana;
    }

    return paluuarvo;
}


string sana = PalautaSanaNKertaa("moi", 5);
Console.WriteLine(sana);
Console.WriteLine(PalautaSanaNKertaa("koulu", 2));
Console.WriteLine(PalautaSanaNKertaa("SAMK", 15));



// for (int i = 0; i < 5; i++)
// {
//     Console.Write("MOI");
// }
// Console.WriteLine();

// for (int i = 0; i < 2; i++)
// {
//     Console.Write("KOULU");
// }
// Console.WriteLine();

// for (int i = 0; i < 15; i++)
// {
//     Console.Write("SAMK");
// }
// Console.WriteLine();