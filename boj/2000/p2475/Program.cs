#nullable disable
string s = Console.ReadLine();
string[] ss = s.Split();
int a = 0;
foreach(string element in ss)
{
    int index = Convert.ToInt32(element);
    a += index * index;
}
Console.WriteLine(a%10);