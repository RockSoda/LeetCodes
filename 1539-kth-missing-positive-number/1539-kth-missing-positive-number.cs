public class Solution 
{
    public int FindKthPositive(int[] arr, int k) 
    {
        var set = arr.ToHashSet();
        int currK = 0;
        int currVal = 0;
        while(currK < k)
        {
            if(!set.Contains(++currVal)) currK++;
        }
        
        return currVal;
    }
}