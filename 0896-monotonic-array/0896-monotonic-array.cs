public class Solution 
{
    private bool IsDec(int[] nums)
    {
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i-1] < nums[i]) return false;
        }
        
        return true;
    }
    
    private bool IsInc(int[] nums)
    {
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i-1] > nums[i]) return false;
        }
        
        return true;
    }
    
    public bool IsMonotonic(int[] nums) => IsDec(nums) || IsInc(nums);
}