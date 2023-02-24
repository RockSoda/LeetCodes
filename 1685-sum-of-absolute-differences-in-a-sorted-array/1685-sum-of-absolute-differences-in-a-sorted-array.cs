public class Solution 
{
    public int[] GetSumAbsoluteDifferences(int[] nums) 
    {
        int size = nums.Length;
        var prefixSum = new int[size];
        prefixSum[0] = nums[0];
        for(int i = 1; i < size; i++)
            prefixSum[i] = prefixSum[i-1] + nums[i];
        
        var suffixSum = new int[size];
        suffixSum[size-1] = nums[size-1];
        for(int i = size-2; i >= 0; i--)
            suffixSum[i] = suffixSum[i+1] + nums[i];
        
        var output = new int[size];
        for(int i = 0; i < size; i++)
        {
            int prefix = i-1 < 0 ? 0 : prefixSum[i-1];
            int suffix = i+1 >= size ? 0 : suffixSum[i+1];
            output[i] = (nums[i]*i - prefix) + (suffix - nums[i]*(size-i-1));
        }
        
        return output;
    }
}