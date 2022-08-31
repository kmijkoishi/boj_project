string s = Console.ReadLine();
int a = Convert.ToInt32(s);
int ans = 1;
if(a == 0)
{
    Console.WriteLine(1);
}
else
{
    for (int i = 1; i < a + 1; i++)
    {
        ans *= i;
    }
    Console.WriteLine(ans);
}
