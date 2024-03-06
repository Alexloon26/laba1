List<int> li1 = new List<int>();
Console.Write("ввести кiлькiсть елементiв:");
int elements = int.Parse(Console.ReadLine());
Random rand = new Random();
for (int i = 0; i < elements; i++)
{
    li1.Add(rand.Next(0, 100));
}
foreach (int chislo in li1)
{
    Console.Write($"{chislo} ");
}
Console.WriteLine();
int tvir=li1.Aggregate(1,(x,y) => (x) * (y%10));
Console.WriteLine(tvir);