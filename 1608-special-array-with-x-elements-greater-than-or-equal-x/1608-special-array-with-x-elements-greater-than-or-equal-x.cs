public class Solution 
{
    public int SpecialArray(int[] nums) 
    {
        Array.Sort(nums);
        
        int counter = 0;
        
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            if(++counter <= nums[i]) continue;
                
            if(counter - 1 == nums[i]) return -1;
                
            return counter-1 > 0 ? counter-1 : -1;
        }
        
        return counter == nums.Length ? counter : -1;
    }
}