public class Solution 
{
    private void ShiftToBack(int[] nums, int index, int len)
    {
        for(int i = index; i < len-1; i++)
        {
            (nums[i], nums[i+1]) = (nums[i+1], nums[i]);
        }
    }
    
    public int RemoveDuplicates(int[] nums) 
    {
        int len = nums.Length;
        for(int i = 1; i < len; i++)
        {
            if(nums[i-1] == nums[i])
            {
                ShiftToBack(nums, i, len);
                i--;
                len--;
            }
        }
        
        return len;
    }
}