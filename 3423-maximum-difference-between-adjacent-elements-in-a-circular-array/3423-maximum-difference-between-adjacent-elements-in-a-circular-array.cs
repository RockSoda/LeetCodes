public class Solution 
{
    public int MaxAdjacentDistance(int[] nums) 
    {
        if(nums.Length < 2) return 0;

        var diff = Math.Abs(nums.First() - nums.Last());

        if(nums.Length == 2) return diff;

        for(int i = 1; i < nums.Length; i++)
            diff = Math.Max(diff, Math.Abs(nums[i-1] - nums[i]));

        return diff;
    }
}