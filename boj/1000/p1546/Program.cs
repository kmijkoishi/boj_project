#nullable disable
string count = Console.ReadLine();
int a = Convert.ToInt32(count);

string s = Console.ReadLine();
string[] ss = s.Split();
int max = 0;
for(int i = 0; i < a; i++)
{
    int index = Convert.ToInt32(ss[i]);
    if(max < index)
    {
        max = index;
    }
}
float total = 0;
for(int i = 0; i < a; i++)
{
    int index = Convert.ToInt32(ss[i]);
    float index2 = ((float)index/max) * 100;
    total += index2;
}
float final = total / a;
Console.WriteLine(final);