public class Solution 
{
    public int FindMaxK(int[] nums) 
    {
        Array.Sort(nums);
        var set = nums.Where(num => num < 0).ToHashSet();
        
        for(int i = nums.Length-1; i >= 0; i--)
        {
            var num = nums[i];
            
            if(num <= 0) break;
            
            if(set.Contains(-num)) return num;
        }
        
        return -1;
    }
}