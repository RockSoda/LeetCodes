public class Solution 
{
    public int ArraySign(int[] nums) 
    {
        bool isZero = nums.Count(n => n == 0) > 0;
        if(isZero) return 0;
        
        bool isNeg = nums.Count(n => n < 0) % 2 == 1;
        if(isNeg) return -1;
        
        return 1;
    }
}