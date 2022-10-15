using System.Collections.Generic;

#nullable disable
List<int> remainders = new List<int>();
int count = 0;

for(int i = 0; i < 10; i++)
{
    string s = Console.ReadLine();
    int a = Convert.ToInt32(s);
    int remainder = a % 42;
    if(!remainders.Contains(remainder))
    {
        count++;
        remainders.Add(remainder);
    }
}
Console.WriteLine(count);