using System.Text;

#nullable disable
string s = Console.ReadLine();
int a = Convert.ToInt32(s);
StringBuilder sb = new StringBuilder();

for(int i = 0; i < a; i++)
{
    s = Console.ReadLine();
    string[] ss = s.Split();
    int b = Convert.ToInt32(ss[0]);
    int c = Convert.ToInt32(ss[1]);
    sb.AppendLine((b+c).ToString());
}
Console.WriteLine(sb.ToString());