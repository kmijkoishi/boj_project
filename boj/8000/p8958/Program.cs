#nullable disable
string count = Console.ReadLine();
int a = Convert.ToInt32(count);
bool previousAns = false;
int score = 0;
int totalScore = 0;

for(int i = 0; i < a; i++)
{
    string s = Console.ReadLine();
    foreach(char c in s)
    {
        if(c == 'O')
        {
            if(previousAns)
            {
                score += 1;
            }
            else
            {
                previousAns = true;
                score = 1;
            }
            totalScore += score;
        }
        else
        {
            score = 0;
            previousAns = false;
        }
    }
    Console.WriteLine(totalScore);
    totalScore = 0;
    score = 0;
    previousAns = false;
}