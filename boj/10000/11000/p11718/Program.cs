using System.Text;

StringBuilder sb = new StringBuilder();
bool isDone = false;
do
{
    string? s = Console.ReadLine();
    if(!string.IsNullOrEmpty(s))
    {
        sb.AppendLine(s);
    }
    else
    {
        isDone = true;
    }

}
while(!isDone);
Console.WriteLine(sb.ToString());