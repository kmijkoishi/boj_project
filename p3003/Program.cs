using System;

namespace p3003
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int[] chess = new int[ss.Length];
            chess[0] = 1 - int.Parse(ss[0]);
            chess[1] = 1 - int.Parse(ss[1]);
            chess[2] = 2 - int.Parse(ss[2]);
            chess[3] = 2 - int.Parse(ss[3]);
            chess[4] = 2 - int.Parse(ss[4]);
            chess[5] = 8 - int.Parse(ss[5]);
            string ans = string.Join(" ", chess);
            Console.WriteLine(ans);
        }
    }
}
