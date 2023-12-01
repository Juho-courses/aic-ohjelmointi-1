// for
string sana = "ohjelmointi";

// for (int j = 0; j < sana.Length; j += 2)
// {
//     Console.Write(sana[j]);
// }

// int index = 0;
// while (index < sana.Length)
// {
//     Console.Write(sana[index]);
//     index += 2;
// }

int i = 0;
foreach (var merkki in sana)
{
    if (i % 2 == 0)
    {
        Console.Write(merkki);
    }
    i++;
}