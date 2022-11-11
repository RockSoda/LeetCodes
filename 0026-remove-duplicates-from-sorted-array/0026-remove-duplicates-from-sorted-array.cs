public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int prev = nums[0];
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(prev == nums[i]) nums[i] = 101;
            else prev = nums[i];
        }
        
        Array.Sort(nums);
        
        return nums.Length - nums.Count(x => x == 101);
    }
}