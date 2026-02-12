public class Solution 
{
    public int MaxAscendingSum(int[] nums) 
    {
        int prev = nums.First(), maxSum = prev, currSum = prev;

        for (int i = 1; i < nums.Length; i++)
        {
            int curr = nums[i];

            if (prev < curr) currSum += curr;
            else
            {
                maxSum = Math.Max(maxSum, currSum);
                currSum = curr;
            }
            
            prev = curr;
        }

        return Math.Max(maxSum, currSum);
    }
}