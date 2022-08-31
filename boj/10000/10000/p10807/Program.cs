#nullable disable
string s = Console.ReadLine();
int count  = Convert.ToInt32(s);
int[] arr = new int[count];

string s2 = Console.ReadLine();
string[] ss2 = s2.Split();

string tgt = Console.ReadLine();
int ans = 0;
foreach (string element in ss2)
{
    if(element == tgt)
    {
        ans++;
    }
}
Console.WriteLine(ans);