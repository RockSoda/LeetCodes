public class Solution 
{
    public int[] SortArrayByParity(int[] nums) 
    {
        int last = nums.Length-1;
        int index = 0;
        while(index < last)
        {
            if(nums[last] % 2 != 0)
            {
                last--;
                continue;
            }
            
            if(nums[index] % 2 != 0)
            {
                (nums[index], nums[last]) = (nums[last], nums[index]);
                last--;
                continue;
            }
            
            index++;
        }
        
        return nums;
    }
}