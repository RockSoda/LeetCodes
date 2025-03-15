public class Solution 
{
    private Dictionary<int, int> memo;
    private bool Traverse(int[] nums, int k, int idx, int cap)
    {
        if(idx >= nums.Length)
        {
            return k <= 0;
        }
        
        if(nums[idx] <= cap) return Traverse(nums, k-1, idx+2, cap);
        
        return Traverse(nums, k, idx+1, cap);
    }

    public int MinCapability(int[] nums, int k) 
    {
        int left = nums.Min(), right = nums.Max(), count = 0, ans = 0;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            if(Traverse(nums, k, 0, mid))
            {
                ans = mid;
                right = mid - 1;
            }
            else left = mid + 1;
        }
        return ans;
    }
}