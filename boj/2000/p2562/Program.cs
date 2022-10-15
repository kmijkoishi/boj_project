int index = 0;
int max = 0;

#nullable disable
for(int i = 0; i < 9; i++)
{
    string s = Console.ReadLine();
    int a = Convert.ToInt32(s);
    if(max == 0)
    {
        max = a;
        index = i+1;
    }
    else
    {
        if(a > max)
        {
            max = a;
            index = i+1;
        }
    }
}
Console.WriteLine(max);
Console.WriteLine(index);