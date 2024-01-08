public class Solution 
{
    public int CountElements(int[] nums) 
    {
        int max = nums.ToList().Max(), min = nums.ToList().Min(), counter = 0;
        foreach(var num in nums)
        {
            if(num > min && num < max) counter++;
        }
        
        return counter;
    }
}