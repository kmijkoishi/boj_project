using System;

namespace p10699
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime timeUtc = DateTime.UtcNow;
            TimeZoneInfo kstZone = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");
            DateTime kstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, kstZone);
            string s = kstTime.ToString("yyyy-MM-dd");
            Console.WriteLine(s);
            */
            DateTime date = DateTime.Now.AddHours(12);
            Console.WriteLine(date.ToString("yyyy-MM-dd"));
        }
    }
}
