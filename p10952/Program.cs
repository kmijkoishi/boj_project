bool isDone = false;

do
{
    string s = Console.ReadLine();
    string[] ss = s.Split();
    int a = Convert.ToInt32(ss[0]);
    int b = Convert.ToInt32(ss[1]);
    if((a == b) && (a == 0))
    {
        isDone = true;
    }
    else
    {
        Console.WriteLine(a + b);
    }
}
while (!isDone);