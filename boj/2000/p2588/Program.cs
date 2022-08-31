using System;

namespace p2588
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ss = Console.ReadLine();

            int a = int.Parse(s);
            int b = int.Parse(ss);

            int first = b % 10;
            int second = (b % 100) - first;
            int third = b - first - second;

            Console.WriteLine(a * first);
            Console.WriteLine((a * second) / 10);
            Console.WriteLine((a * third) / 100);
            Console.WriteLine(a * b);
        }
    }
}
