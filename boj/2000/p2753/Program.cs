using System;

namespace p2753
{
    class Program
    {
        static void Main(string[] args)
        {
            #nullable disable
            string s = Console.ReadLine();
            int year = int.Parse(s);
            if(year % 4 == 0)
            {
                if((year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}