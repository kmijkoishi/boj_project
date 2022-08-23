using System;

namespace p14681
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ss = Console.ReadLine();
            int a = int.Parse(s);
            int b = int.Parse(ss);
            int added = a + b;
            int multiplied = a * b;
            if(multiplied > 0)
            {
                if(added > 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("3");
                }
            }
            else
            {
                if(a > 0)
                {
                    Console.WriteLine("4");
                }
                else
                {
                    Console.WriteLine("2");
                }
            }
        }
    }
}
