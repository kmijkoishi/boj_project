#nullable disable
string count = Console.ReadLine();
int a = Convert.ToInt32(count);
int max = 0;
int min = 0;

int[] arr = new int[a];
string s = Console.ReadLine();
string[] starr = s.Split();
for(int i =0; i < a; i++)
{
    arr[i] = Convert.ToInt32(starr[i]);
}
foreach(int ele in arr)
{
    if(max == 0)
    {
        max = ele;
        min = ele;
    }
    else
    {
        if(ele > max)
        {
            max = ele;
        }
        else if(ele < min)
        {
            min = ele;
        }
    }

}
Console.WriteLine(min + " " + max);