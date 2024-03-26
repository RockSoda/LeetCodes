public class Solution 
{
    public int FirstMissingPositive(int[] nums) 
    {
        Array.Sort(nums);
        int missing = 1;
        foreach(var num in nums)
        {
            if(num >= 1 && num == missing) missing++;
        }
        return missing;
    }
}