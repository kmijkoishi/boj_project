#nullable disable
string s = Console.ReadLine();
if(s == "1 2 3 4 5 6 7 8")
{
    Console.WriteLine("ascending");
}
else if(s == "8 7 6 5 4 3 2 1")
{
    Console.WriteLine("descending");
}
else
{
    Console.WriteLine("mixed");
}