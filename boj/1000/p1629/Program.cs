#nullable disable
string s = Console.ReadLine();
string[] ss = s.Split();
long a = Convert.ToInt64(ss[0]);
long b = Convert.ToInt64(ss[1]);
long c = Convert.ToInt64(ss[2]);
long d = a * b;
long e = d % c;
Console.WriteLine(e);