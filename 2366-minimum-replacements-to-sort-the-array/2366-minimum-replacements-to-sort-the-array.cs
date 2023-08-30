public class Solution 
{
    public long MinimumReplacement(int[] nums) 
    {
        if (nums.Length == 1) return 0;
        long opr = 0, prev = nums.Last();
        
        for (int i = nums.Length - 2; i >= 0; i--) 
        {
            long num = nums[i];
            long times = (num + prev - 1) / prev;
            opr += times - 1;
            prev = num / times;
        }
        
        return opr;
    }
}