using System.Text;

#nullable disable
string count = Console.ReadLine();
int a = Convert.ToInt32(count);
StringBuilder sb = new StringBuilder();

for(int i = 0; i < a; i++)
{
    string s = Console.ReadLine();
    string[] ss = s.Split();
    int repeat = Convert.ToInt32(ss[0]);
    foreach(char c in ss[1])
    {
        for(int j = 0; j < repeat; j++)
        {
            sb.Append(c);
        }
    }
    sb.AppendLine();
}
Console.WriteLine(sb.ToString());