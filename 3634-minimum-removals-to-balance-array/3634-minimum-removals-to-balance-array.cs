public class Solution
{
    public int MinRemoval(int[] nums, int k)
    {
        Array.Sort(nums);
        int maxWindow = 0;
        int left = 0;
        for(int right = 0; right < nums.Length; right++)
        {
            while((long)nums[right] > (long)nums[left]*k) left++;

            maxWindow = Math.Max(maxWindow, right - left + 1);
        }

        return nums.Length - maxWindow;
    }
}