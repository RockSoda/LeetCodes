public class Solution 
{
    public int LongestMonotonicSubarray(int[] nums) 
    {
        int prev = nums.First(), lenIncreasing = 1, lenDecreasing = 1, maxLen = 1;

        void ResetVal(ref int val)
        {
            maxLen = Math.Max(maxLen, val);
            val = 1;
        }

        int GetMax(int a, int b, int c) => Math.Max(Math.Max(a, b), c);

        for(int i = 1; i < nums.Length; i++)
        {
            int curr = nums[i];
            if(prev > curr)
            {
                lenDecreasing++;
                ResetVal(ref lenIncreasing);
            }
            else if(prev < curr)
            {
                lenIncreasing++;
                ResetVal(ref lenDecreasing);
            }
            else
            {
                ResetVal(ref lenIncreasing);
                ResetVal(ref lenDecreasing);
            }
            prev = curr;
        }
        return GetMax(lenIncreasing, lenDecreasing, maxLen);
    }
}