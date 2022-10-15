#nullable disable
string s = Console.ReadLine();
string[] ss = s.Split();
long a = Convert.ToInt32(ss[0]);
long b = Convert.ToInt32(ss[1]);
Console.WriteLine((a+b) * (a-b));