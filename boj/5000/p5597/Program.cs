using System.Collections.Generic;

List<int> arr = new List<int>();

for(int i = 0; i < 30; i++)
{
    arr.Add(i+1);
}

#nullable disable
for(int i = 0; i < 28; i++)
{
    string s = Console.ReadLine();
    int a = Convert.ToInt32(s);
    if(arr.Contains(a))
    {
        arr.Remove(a);
    }
}
if(arr[0] < arr[1])
{
    Console.WriteLine(arr[0]);
    Console.WriteLine(arr[1]);
}
else
{
    Console.WriteLine(arr[1]);
    Console.WriteLine(arr[0]);
}