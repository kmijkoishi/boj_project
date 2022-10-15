#nullable disable
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = a * b * c;
string s = Convert.ToString(d);
int[] result = new int[10];
for(int i = 0; i < result.Length; i++)
{
    result[i] = 0;
}

foreach(char chr in s)
{
    int index = Convert.ToInt32(chr.ToString());
    // Console.WriteLine(Convert.ToInt32(chr.ToString()) + ", " + chr);
    // Console.WriteLine(index);
    result[index]++;
}
foreach(int ele in result)
{
    Console.WriteLine(ele);
}