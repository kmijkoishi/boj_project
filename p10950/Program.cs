string s = Console.ReadLine();
int count = Convert.ToInt32(s);

for (int i = 0; i < count; i++)
{
    string ss = Console.ReadLine();
    string[] ssarray = ss.Split();
    int a = Convert.ToInt32(ssarray[0]);
    int b = Convert.ToInt32(ssarray[1]);
    Console.WriteLine(a + b);
}