using System.Collections.Generic;

#nullable disable
string pplAndParty = Console.ReadLine();
string[] paparr = pplAndParty.Split();

int ppl = Convert.ToInt32(paparr[0]);
int party = Convert.ToInt32(paparr[1]);

List<int> pplList = new List<int>();

for(int i = 0; i < ppl; i++)
{
    pplList.Add(i+1);
}

string truePpl = Console.ReadLine();
string[] truePplarr = truePpl.Split();

List<int> truePplList = new List<int>();

for(int i = 1; i < truePplarr.Length; i++)
{
    truePplList.Add(Convert.ToInt32(truePplarr[i]));
}

foreach(int i in pplList.ToList())
{
    if(truePplList.Contains(i))
    {
        pplList.Remove(i);
    }
}
string[] partyList = new string[party];
for(int i = 0; i < partyList.Length; i++)
{
    partyList[i] = Console.ReadLine();
    // Console.WriteLine(i + "party setted");
}


List<int> impossiblePartyCount = new List<int>();
// Console.WriteLine("imm: " + impossiblePartyCount.Count);

bool isDone = false;
do
{
    // Console.WriteLine("test");
    int index = impossiblePartyCount.Count;
    // Console.WriteLine("index: " + index);
    // Console.WriteLine("imm: " + impossiblePartyCount.Count);
    for(int i = 0; i < partyList.Length; i++)
    {
        string[] ss = partyList[i].Split();
        for(int j = 1; j < ss.Length; j++)
        {
            if(!impossiblePartyCount.Contains(i))
            {
                if(truePplList.Contains(Convert.ToInt32(ss[j])))
                {
                    impossiblePartyCount.Add(i);
                    for(int k = 1; k < ss.Length; k++)
                    {
                        if(!truePplList.Contains(Convert.ToInt32(ss[k])))
                        {
                            truePplList.Add(Convert.ToInt32(ss[k]));
                        }
                    }
                    break;
                }
            }
        }
    }
    if(index == impossiblePartyCount.Count)
    {
        isDone = true;
    }
}
while(!isDone);
// foreach(int ele in impossiblePartyCount)
// {
//     Console.Write(ele);
// }
Console.WriteLine(party - impossiblePartyCount.Count);