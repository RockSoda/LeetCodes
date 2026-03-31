public class Solution 
{
    public int FindMiddleIndex(int[] nums) 
    {
        var sum = nums.Sum();
        var left = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            sum -= num;
            if(left == sum) return i;
            left += num;
        }

        return -1;
    }
}