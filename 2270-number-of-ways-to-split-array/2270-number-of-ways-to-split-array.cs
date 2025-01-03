public class Solution 
{
    public int WaysToSplitArray(int[] nums) 
    {
        int size = nums.Length;
        var prefixSum = new int[size];
        prefixSum[0] = nums[0];
        for(int i = 1; i < size; i++) prefixSum[i] = prefixSum[i-1] + nums[i];

        var suffixSum = new int[size];
        suffixSum[size-1] = nums[size-1];
        for(int i = size-2; i >= 0; i--) suffixSum[i] = suffixSum[i+1] + nums[i];

        var output = 0;
        for(int i = 1; i < size; i++) if(prefixSum[i-1] >= suffixSum[i]) output++;
        
        return output;
    }
}