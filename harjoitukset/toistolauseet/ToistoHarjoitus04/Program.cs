Console.Write("montako sanaa syötät: ");
int user_count = int.Parse(Console.ReadLine());

int count = 0;
string word = "";
int pituudet = 0;

while (count < user_count)
{
    Console.Write("sana: ");
    word = Console.ReadLine();

    if (word != "")
    {
        // otetaan pituus talteen
        pituudet = pituudet + word.Length;
        count++;
    }
}

Console.WriteLine(pituudet);