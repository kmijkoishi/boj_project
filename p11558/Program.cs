#nullable disable
int testCount = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < testCount; i++)
{
    int pplCount = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[pplCount];
    for(int j = 0; j < pplCount; j++)
    {
        arr[j] = Convert.ToInt32(Console.ReadLine());
    }

    int index = 1;
    int count = 0;
    bool isPossible = false;

    for(int j = 0; j < arr.Length; j++)
    {
        index = arr[index - 1];
        count++;

        if(index == pplCount)
        {
            isPossible = true;
            break;
        }
        if(index == 1 && count != 0)
        {
            break;
        }
    }
    if(isPossible)
    {
        Console.WriteLine(count);
    }
    else
    {
        Console.WriteLine(0);
    }
}