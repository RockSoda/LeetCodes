public class Solution 
{
    public int FindMiddleIndex(int[] nums) 
    {
        var suffixSum = new int[nums.Length];
        suffixSum[nums.Length-1] = nums[nums.Length-1];
        for(int i = nums.Length-2; i >= 0; i--) suffixSum[i] += suffixSum[i+1] + nums[i];

        var sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if(sum == suffixSum[i]) return i;
        }

        return -1;
    }
}