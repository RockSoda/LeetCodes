public class Solution 
{
    public long MaximumHappinessSum(int[] happiness, int k) 
    {
        var childrenToPick = happiness.OrderByDescending(n => n).Take(k).ToList();
        long output = 0;
        for(int i = 0; i < k; i++)
        {
            var happyVal = childrenToPick[i] - i;
            output += happyVal < 0 ? 0 : happyVal;
        }
        return output;
    }
}