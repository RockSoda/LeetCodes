public class Solution 
{
    public int MinOperations(int[] nums, int x) 
    {
        int target = nums.Sum() - x, n = nums.Length;
        
        if(target == 0) return n;
        
        int maxLen = 0, curSum = 0, left = 0, right = 0;
        
        while(right < n)
        {
            curSum += nums[right];
            
            while(left <= right && curSum > target) curSum -= nums[left++];
            
            if(curSum == target) maxLen = Math.Max(maxLen, right - left + 1);
            
            right++;
        }
        
        return maxLen != 0 ? n - maxLen : -1;
    }
}