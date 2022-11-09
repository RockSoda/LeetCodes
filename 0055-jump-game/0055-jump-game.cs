public class Solution 
{
    private bool Recurse(int[] nums, int index, bool?[] memo)
    {
        if(index >= nums.Length-1) return true;
        
        if(memo[index] != null) return (bool)memo[index];
        
        bool canJump = false;
        
        for(int i = nums[index]; i >= 1; i--) canJump = canJump || Recurse(nums, index+i, memo);
        
        memo[index] = canJump;
        return canJump;
    }
    
    public bool CanJump(int[] nums) 
    {
        var memo = new bool?[nums.Length];
        return Recurse(nums, 0, memo);
    }
}