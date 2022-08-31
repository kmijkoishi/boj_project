#nullable disable
using System.Text;

string s = Console.ReadLine();
int a = Convert.ToInt32(s);
StringBuilder sb = new StringBuilder();
for(int i = 0; i < 9; i++)
{
    sb.AppendLine(a + " * " + (i+1) + " = " + (a * (i+1)));
}
Console.WriteLine(sb.ToString());