public class Solution 
{
    public int MaxAbsoluteSum(int[] nums) 
    {
        var len = nums.Length;
        var prefixSum = new int[len];
        prefixSum[0] = nums[0];

        for(int i = 1; i < len; i++) prefixSum[i] = prefixSum[i-1] + nums[i];

        int absSum = 0;
        for(int i = len-1; i >= 0; i--)
        {   
            absSum = Math.Max(absSum, Math.Abs(prefixSum[i]));
            bool isBreaked = false;
            for(int j = 0; j < len; j++)
            {
                absSum = Math.Max(absSum, Math.Abs(prefixSum[i]-prefixSum[j]));
                if(j > i) break;
            }
            if(isBreaked) break;
        }

        return absSum;
    }
}