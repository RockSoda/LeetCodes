public class Solution 
{
    public int[] ConstructTransformedArray(int[] nums) 
    {
        int GetNextVal(int idx, int val)
        {
            idx += val;
            idx %= nums.Length;
            if(idx >= nums.Length) idx -= nums.Length;
            else if(idx < 0) idx += nums.Length;
            return nums[idx];
        }

        var output = new int[nums.Length];
        
        for(int i = 0; i < nums.Length; i++) output[i] = GetNextVal(i, nums[i]);

        return output;
    }
}