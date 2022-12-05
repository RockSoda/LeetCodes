public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0;
        int right = left;
        int curr = nums[left];
        int len = 0;
        while (left <= right)
        {
            int prevL = left;
            int prevR = right;
            if (curr >= target)
            {
                if (len == 0) len = right - left + 1;
                else len = Math.Min(right - left + 1, len);

                curr -= nums[left++];
            }
            else if (right < nums.Length - 1) curr += nums[++right];

            if (prevL == left && prevR == right) break;
        }

        return len;
    }
}