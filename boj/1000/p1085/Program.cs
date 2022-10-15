#nullable disable
string s = Console.ReadLine();
string[] ss = s.Split();
int[] arr = new int[4];
arr[0] = Convert.ToInt32(ss[0]);
arr[1] = Convert.ToInt32(ss[1]);
int w = Convert.ToInt32(ss[2]);
int h = Convert.ToInt32(ss[3]);
arr[2] = w - arr[0];
arr[3] = h - arr[1];
int min = 0;

for(int i = 0; i < arr.Length; i++)
{
    if(i == 0)
    {
        min = arr[i];
    }
    else
    {
        if(min > arr[i])
        {
            min = arr[i];
        }
    }
}
Console.WriteLine(min);