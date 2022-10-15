using System.Text;

#nullable disable
string count = Console.ReadLine();
int a = Convert.ToInt32(count);
StringBuilder sb = new StringBuilder();

for(int i = 0; i < a; i++)
{
    string s = Console.ReadLine();
    sb.AppendLine(s[0] + "" + s[s.Length - 1]);
}
Console.WriteLine(sb.ToString());