using System.Text;

#nullable disable
String s = Console.ReadLine();
String[] ss = s.Split();
int n = Convert.ToInt32(ss[0]);
int m = Convert.ToInt32(ss[1]);
int[,] arr1 = new int[n, m];
int[,] arr2 = new int[n, m];

for(int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    string[] strarr = str.Split();
    for(int j = 0; j < m; j++)
    {
        int index = Convert.ToInt32(strarr[j]);
        arr1[i, j] = index;
    }
}
for(int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    string[] strarr = str.Split();
    for(int j = 0; j < m; j++)
    {
        int index = Convert.ToInt32(strarr[j]);
        arr2[i, j] = index;
    }
}

StringBuilder sb = new StringBuilder();
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        sb.Append((arr1[i, j] + arr2[i, j]) + " ");
    }
    sb.AppendLine();
}
Console.WriteLine(sb.ToString());