Console.Write("asia 1: ");
string asia1 = Console.ReadLine();

Console.Write("asia 2: ");
string asia2 = Console.ReadLine();

if (asia1.Length > asia2.Length)
{
    Console.WriteLine(asia1);
}
else if (asia2.Length > asia1.Length)
{
    Console.WriteLine(asia2);
}
else if (asia1.Length == asia2.Length)
{
    Console.WriteLine(asia1.Length + asia2.Length);
}