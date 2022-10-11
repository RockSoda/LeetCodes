public class Solution 
{
    public bool IncreasingTriplet(int[] nums) 
    {
        if(nums.Length < 3) return false;
        
        int min = int.MaxValue, mid = int.MaxValue;
        foreach(var num in nums)
        {
            if(num < min) min = num;
            else if(num > min && num < mid) mid = num;
            else if(num > mid) return true;
        }
        
        return false;
    }
}