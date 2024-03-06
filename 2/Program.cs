using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
Dictionary<int, int> slovnik = new Dictionary<int, int>();
Console.Write("ввести кiлькiсть елементiв:");
int elements = int.Parse(Console.ReadLine());
Random rand = new Random();
for (int i = 0; i < elements; i++)
{
   slovnik.Add(i,rand.Next(-10, 10));
}
Console.WriteLine("Незмiнений словник:");
foreach (var chislo in slovnik)
{
    Console.WriteLine($"{chislo.Key}: {chislo.Value}");
}
int sumvalues = 0;
for (int i = 0; i < elements; i++)
{
    sumvalues += slovnik[i];
}
for (int i = 0; i < elements; i++)
{
    slovnik[i]=sumvalues;
}
Console.WriteLine("Змiнений словник:");
string json = JsonConvert.SerializeObject(slovnik);
string path = "slonik.json";
File.WriteAllText(path, json);
Console.WriteLine(json);