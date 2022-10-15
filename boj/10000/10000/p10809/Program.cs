#nullable disable
string s = Console.ReadLine();
char[] carray = s.ToCharArray();
int asciia = (int)'a';
int[] arr = new int[26];

for(int i = 0; i < 26; i++)
{
    bool isExist = false;
    for(int j = 0; j < carray.Length; j++)
    {
        if(carray[j] == asciia + i)
        {
            isExist = true;
            arr[i] = j;
            break;
        }
    }
    if(!isExist) arr[i] = -1;
}
foreach(int i in arr)
{
    Console.Write(i + " ");
}