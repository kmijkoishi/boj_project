#nullable disable
string s = Console.ReadLine();
char[] carray = s.ToCharArray();
float score = 0f;
if(carray[0] != 'F')
{
    switch(carray[0])
    {
        case 'A':
            score = 4f;
            break;
        case 'B':
            score = 3f;
            break;
        case 'C':
            score = 2f;
            break;
        case 'D':
            score = 1f;
            break;
        default:
            score = 0f;
            break;
    }
    switch(carray[1])
    {
        case '+':
            score += 0.3f;
            break;
        case '-':
            score -= 0.3f;
            break;
        default:
            break;
    }
}

Console.WriteLine("{0:0.0}", score);