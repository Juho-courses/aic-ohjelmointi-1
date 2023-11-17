string name = "Jaska Ollinpoika";

if (name.Length == 5)
{
    Console.WriteLine("viisi merkkiä pitkä");
}
else
{
    Console.WriteLine("pituus on : " + name.Length);
}

Console.WriteLine(name.Substring(0, 2));
Console.WriteLine(name.StartsWith("Juho"));