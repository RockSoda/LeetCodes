public class Solution 
{
    public int[] GetFinalState(int[] nums, int k, int multiplier) 
    {
        for(int i = 0; i < k; i++)
        {
            var minIdx = Array.IndexOf(nums, nums.Min());
            nums[minIdx] *= multiplier;
        }
        return nums;
    }
}