List<int> chisla= new List<int>();
Console.Write("ввести кiлькiсть елементiв:");
int elements=int.Parse(Console.ReadLine());
Random rand= new Random();
for (int i = 0; i < elements; i++)
{
    chisla.Add(rand.Next(-10, 10));
}
Console.Write("несортований список:");
foreach (int chislo in chisla)
{
    Console.Write($"{chislo} ");
}
Console.WriteLine();
chisla.Sort();
chisla.Reverse();
Console.Write("сортований список:");
foreach (int chislo in chisla)
{
    Console.Write($"{chislo} ");
}
Console.WriteLine();


