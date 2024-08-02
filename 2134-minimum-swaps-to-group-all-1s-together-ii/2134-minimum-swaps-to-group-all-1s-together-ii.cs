public class Solution 
{
    public int MinSwaps(int[] nums) 
    {
        int window = 0;

        foreach (var num in nums)
            if (num == 1) window++;

        int n = nums.Length;
        int zero = 0;

        for (int i = 0; i < window; i++)
            if (nums[i] == 0) zero++;

        int swap = zero;

        for (int i = window; i < n + window; i++)
        {
            if (nums[i % n] == 0) zero++;

            if (nums[i - window] == 0) zero--;

            swap = Math.Min(swap, zero);
        }

        return swap;
    }
}