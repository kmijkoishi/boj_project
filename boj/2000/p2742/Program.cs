using System.Text;

#nullable disable
int a = Convert.ToInt32(Console.ReadLine());
StringBuilder sb = new StringBuilder();

for(int i = 0; i < a; i++)
{
    sb.AppendLine((a-i).ToString());
}
Console.WriteLine(sb.ToString());