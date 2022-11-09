public class Solution 
{
    private int[] memo;
    
    private bool recurse(int[] nums, int index)
    {
        if(index >= nums.Length-1) return true;

        if(memo[index] != -1) return memo[index] == 1 ? true : false;
        bool res = false;
        for(int i = nums[index]; i >= 1; i--) res = res || recurse(nums, i+index);

        memo[index] = res ? 1 : 0;
        return res;
    }
    public bool CanJump(int[] nums) 
    {
        memo = new int[nums.Length];
        Array.Fill(memo, -1);
        return recurse(nums, 0);
    }
}