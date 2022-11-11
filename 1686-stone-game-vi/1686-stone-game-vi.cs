public class Solution 
{
    public int StoneGameVI(int[] aliceValues, int[] bobValues) 
    {
        int alice = 0;
        int bob = 0;
        bool isAliceTurn = true;
        
        List<(int a, int b, int s)> list = new();
        for(int i = 0; i < aliceValues.Length; i++) 
            list.Add((aliceValues[i], bobValues[i], aliceValues[i]+bobValues[i]));
        list = list.OrderByDescending(item => item.s).ToList();
        
        for(int i = 0; i < list.Count; i++)
        {
            if(isAliceTurn) alice += list[i].a;
            else bob += list[i].b;
            isAliceTurn = !isAliceTurn;
        }
        
        if(alice < bob) return -1;
        else if(alice > bob) return 1;
        else return 0;
    }
}