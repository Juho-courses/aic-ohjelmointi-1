int a = 2;
a.ToString();

string a2 = "false";
bool b = bool.Parse(a2);
Console.WriteLine(b);

Console.Write("Kirjoita numero:");
string input = Console.ReadLine();

int summa = int.Parse(input) + 2;
Console.WriteLine(summa);