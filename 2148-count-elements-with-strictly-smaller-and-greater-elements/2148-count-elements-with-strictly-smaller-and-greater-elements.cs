public class Solution 
{
    public int CountElements(int[] nums) 
    {
        var counter = 0;
        foreach(var num in nums)
        {
            if(nums.Any(n => n > num) && nums.Any(n => n < num)) counter++;
        }
        
        return counter;
    }
}