public class Solution 
{
    public long LargestPerimeter(int[] nums) 
    {
        Array.Sort(nums);
        
        long sum = nums.Select(x => (long)x).Sum();
        
        int i = nums.Length-1;
        
        for(; i >= 0; i--)
        {
            sum -= nums[i];
            if(sum > nums[i]) break;
        }
        
        return i >= 2 ? sum + nums[i] : -1;
    }
}