public class Solution 
{
    public int[] BuildArray(int[] nums) 
    {
        int len = nums.Length;
        for(int i = 0; i < len; i++)
        {
            nums[i] += len * (nums[nums[i]] % len);
        }

        for(int i = 0; i < len; i++)
        {
            nums[i] /= len;
        }

        return nums;
    }
}