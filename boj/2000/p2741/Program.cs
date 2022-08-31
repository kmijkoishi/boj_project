using System;
using System.Text;

namespace p2753
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);

            for (int i = 1; i < a+1; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
