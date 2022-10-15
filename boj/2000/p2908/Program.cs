#nullable disable
string s = Console.ReadLine();
string[] ss = s.Split();
char[] c1 = ss[0].ToCharArray();
char[] c2 = ss[1].ToCharArray();
Array.Reverse(c1);
Array.Reverse(c2);
int a = Convert.ToInt32(new string(c1));
int b = Convert.ToInt32(new string(c2));
if(a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}