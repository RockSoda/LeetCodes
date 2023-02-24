public class Solution 
{
    public int[] GetSumAbsoluteDifferences(int[] nums) 
    {
        var prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];
        for(int i = 1; i < nums.Length; i++)
            prefixSum[i] = prefixSum[i-1] + nums[i];
        
        var suffixSum = new int[nums.Length];
        suffixSum[suffixSum.Length-1] = nums[nums.Length-1];
        for(int i = nums.Length-2; i >= 0; i--)
            suffixSum[i] = suffixSum[i+1] + nums[i];
        
        var output = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            int prefix = i-1 < 0 ? 0 : prefixSum[i-1];
            int suffix = i+1 >= nums.Length ? 0 : suffixSum[i+1];
            output[i] = (nums[i]*i - prefix) + (suffix - nums[i]*(nums.Length-i-1));
        }
        
        return output;
    }
}