public class Solution 
{
    public int CountElements(int[] nums) 
    {
        var list = nums.ToList();
        int max = list.Max(), min = list.Min(), counter = 0;
        foreach(var num in nums)
        {
            if(num > min && num < max) counter++;
        }
        
        return counter;
    }
}