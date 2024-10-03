public class Solution 
{
    public int MinSubarray(int[] nums, int p) 
    {
        int remainder = 0;
        foreach(var num in nums)
        {
            remainder += num % p;
            remainder %= p;
        }
        if(remainder == 0) return 0;

        var prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
            prefixSum[i] = prefixSum[i-1] + nums[i];
        
        var minLen = 100001;

        int currSum = 0;
        var dictPrefixSum = new Dictionary<int, int>() { { 0, -1 } };
        for (int i = 0; i < nums.Length; i++)
        {
            currSum = (currSum + nums[i]) % p;
            int diff = (currSum - remainder + p) % p;

            if (dictPrefixSum.ContainsKey(diff))
                minLen = Math.Min(minLen, i - dictPrefixSum[diff]);

            dictPrefixSum[currSum] = i;
        }

        return (minLen == nums.Length || minLen == 100001) ? -1 : minLen;
    }
}