#nullable disable
string s = Console.ReadLine();
s = s.ToUpper();
Dictionary<char, int> dic = new Dictionary<char, int>();

foreach(char c in s)
{
    if(!dic.ContainsKey(c))
    {
        dic.Add(c, 1);
    }
    else
    {
        int index = dic[c];
        index++;
        dic[c] = index;
    }
}

int max = 0;
char maxChar = '0';
bool isDupe = false;
foreach(KeyValuePair<char, int> ele in dic)
{
    if(ele.Value > max)
    {
        max = ele.Value;
        maxChar = ele.Key;
    }
}
foreach(KeyValuePair<char, int> ele in dic)
{
    if((ele.Value == max) && (ele.Key != maxChar))
    {
        Console.WriteLine("?");
        isDupe = true;
        break;
    }
}
if(!isDupe) Console.WriteLine(maxChar);

