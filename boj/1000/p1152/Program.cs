#nullable disable
string s = Console.ReadLine();
string[] ss = s.Split();
int count = ss.Length;
foreach (string ele in ss)
{
    if(string.IsNullOrEmpty(ele))
    {
        count--;
    }
}
Console.WriteLine(count);