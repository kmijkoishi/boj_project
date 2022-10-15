#nullable disable
Console.ReadLine();
string s = Console.ReadLine();
int total = 0;

foreach (char c in s)
{
    int a = Convert.ToInt32(c.ToString());
    total += a;
}
Console.WriteLine(total);

