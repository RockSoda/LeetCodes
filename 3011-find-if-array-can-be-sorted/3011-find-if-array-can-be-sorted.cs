public class Solution 
{
    public bool CanSortArray(int[] nums) 
    {
        var setBits = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
            setBits[i] = Convert.ToString(nums[i], 2).Count(c => c == '1');
        
        int currMax = int.MinValue, currMin = int.MaxValue, prevBit = -1;
        var stk = new Stack<(int min, int max)>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(prevBit == setBits[i])
            {
                currMin = Math.Min(currMin, nums[i]);
                currMax = Math.Max(currMax, nums[i]);
            }
            else
            {
                if(stk.Count > 0 && stk.Peek().max >= currMin) return false;
                stk.Push((currMin, currMax));
                currMax = nums[i];
                currMin = nums[i];
                prevBit = setBits[i];
            }
        }
        
        if(stk.Count > 0 && stk.Peek().max >= currMin) return false;
        return true;
    }
}