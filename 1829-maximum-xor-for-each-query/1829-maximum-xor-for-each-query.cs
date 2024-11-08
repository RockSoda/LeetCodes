public class Solution 
{
    public int[] GetMaximumXor(int[] nums, int maximumBit) 
    {
        var maxVal = (int)Math.Pow(2, maximumBit) - 1;
        var prefixed = new int[nums.Length];

        prefixed[0] = nums[0];
        for(int i = 1; i < nums.Length; i++)
            prefixed[i] = prefixed[i-1] ^ nums[i];
        
        for(int i = 0; i < nums.Length; i++)
            prefixed[i] ^= maxVal;
        
        Array.Reverse(prefixed);
        return prefixed;
    }
}