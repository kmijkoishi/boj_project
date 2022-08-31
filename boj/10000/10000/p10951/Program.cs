bool isDone = false;

do
{
    string? s = Console.ReadLine();
    if(!String.IsNullOrEmpty(s))
    {
        string[] ss = s.Split();
        int a = Convert.ToInt32(ss[0]);
        int b = Convert.ToInt32(ss[1]);

        Console.WriteLine(a + b);
    }
    else
    {
        isDone = true;
    }
}
while(!isDone);