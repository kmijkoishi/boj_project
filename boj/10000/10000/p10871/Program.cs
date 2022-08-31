using System.Text;

#nullable disable
string s = Console.ReadLine();
string[] ss = s.Split();

int a = Convert.ToInt32(ss[0]);
int b = Convert.ToInt32(ss[1]);

int[] arr = new int[a];

string str = Console.ReadLine();
string[] strarr = str.Split();
StringBuilder sb = new StringBuilder();

foreach(string element in strarr)
{
    int intelement = Convert.ToInt32(element);
    if(intelement < b)
    {
        sb.Append(intelement + " ");
    }
}
Console.WriteLine(sb.ToString());
