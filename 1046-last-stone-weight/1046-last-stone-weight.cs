public class Solution 
{   
    private (int, int)[] GetTopTwo(int[] stones)
    {
        int max = stones.Max();
        int maxI = -1;
        int max2 = int.MinValue;
        int max2I = -1;
        for(int i = 0; i < stones.Length; i++)
        {
            if(stones[i] == max && maxI == -1) maxI = i;
            
            if(stones[i] > max2 && i != maxI)
            {
                max2 = stones[i];
                max2I = i;
            }
        }
        
        return new (int, int)[]{(maxI, max), (max2I, max2)};
    }
    
    public int LastStoneWeight(int[] stones) 
    {
        if(stones.Count(s => s > 0) <= 1) return stones.Sum();

        (int index, int val)[] topTwo = GetTopTwo(stones);
        
        stones[topTwo[0].index] -= stones[topTwo[1].index];
        stones[topTwo[1].index] = 0;
        
        return LastStoneWeight(stones.ToArray());
    }
}