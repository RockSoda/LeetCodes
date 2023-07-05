public class Solution 
{
    private int GetMax(int[] nums, Dictionary<(int, bool), int> memo, int index = 0, bool isDeleted = false, int curr = 0)
    {
        if(index >= nums.Length) return isDeleted ? curr : curr-1;
        if(nums[index] != 1 && isDeleted) return curr;
        
        if(memo.ContainsKey((index, isDeleted))) return memo[(index, isDeleted)];
        
        if(nums[index] != 1) 
            return memo[(index, isDeleted)] = Math.Max(GetMax(nums, memo, index+1, true, curr), GetMax(nums, memo, index+1, false, 0));
        else 
            return memo[(index, isDeleted)] = GetMax(nums, memo, index+1, isDeleted, curr+1);
        
    }
    
    public int LongestSubarray(int[] nums) 
    {
        return GetMax(nums, new Dictionary<(int, bool), int>());
    }
}