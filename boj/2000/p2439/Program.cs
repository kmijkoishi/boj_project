using System.Text;

#nullable disable
string s = Console.ReadLine();
int a = Convert.ToInt32(s);
StringBuilder sb = new StringBuilder();

for(int i = 0; i < a; i++)
{
    for(int j = 0; j < a - i - 1; j++)
    {
        sb.Append(" ");
    }
    for(int j = 0; j < i+1; j++)
    {
        sb.Append("*");
    }
    sb.AppendLine();
}
Console.WriteLine(sb.ToString());