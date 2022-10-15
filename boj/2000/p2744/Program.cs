#nullable disable
string s = Console.ReadLine();
char[] carray = s.ToCharArray();
foreach (char c in carray)
{
    if(char.IsUpper(c))
    {
        Console.Write(char.ToLower(c));
    }
    else
    {
        Console.Write(char.ToUpper(c));
    }
}