// See https://aka.ms/new-console-template for more information
#nullable disable
string s = Console.ReadLine();
string[] ss = s.Split();
long a = long.Parse(ss[0]);
long b = long.Parse(ss[1]);
long c = a - b;
c = Math.Abs(c);
Console.WriteLine(c);
