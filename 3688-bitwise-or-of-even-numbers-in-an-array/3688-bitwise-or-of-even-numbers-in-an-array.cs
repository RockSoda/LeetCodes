public class Solution 
{
    public int EvenNumberBitwiseORs(int[] nums) 
    {
        var bitwiseOr = 0;
        foreach(var num in nums)
        {
            if((int)(num & 1) == 1) continue;

            bitwiseOr |= num;
        }
        return bitwiseOr;
    }
}