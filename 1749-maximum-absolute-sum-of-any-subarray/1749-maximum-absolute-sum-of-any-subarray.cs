public class Solution 
{
    public int MaxAbsoluteSum(int[] nums) 
    {
        int currMin = 0, currMax = 0, min = 0, max = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            currMin += nums[i];
            currMax += nums[i];
            if(currMin > 0) currMin = 0;
            if(currMax < 0) currMax = 0;
             
            min = Math.Min(min, currMin);
            max = Math.Max(max, currMax);
        }
        return Math.Max(Math.Abs(min), max);
    }
}