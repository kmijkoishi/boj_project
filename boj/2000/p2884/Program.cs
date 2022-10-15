#nullable disable
string s = Console.ReadLine();
string[] ss = s.Split();

int hour = Convert.ToInt32(ss[0]);
int minute = Convert.ToInt32(ss[1]);

minute -= 45;
if(minute < 0)
{
    if(hour == 0)
    {
        hour = 23;
    }
    else
    {
        hour--;
    }
    minute += 60;
}
Console.WriteLine(hour + " " + minute);