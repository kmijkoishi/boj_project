using System;

namespace p11382
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            long a = long.Parse(ss[0]);
            long b = long.Parse(ss[1]);
            long c = long.Parse(ss[2]);

            Console.WriteLine(a + b + c);
        }
    }
}
