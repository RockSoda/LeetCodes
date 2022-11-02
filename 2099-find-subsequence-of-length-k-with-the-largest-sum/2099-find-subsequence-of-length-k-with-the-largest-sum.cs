public class Solution 
{
    public int[] MaxSubsequence(int[] nums, int k) 
    {
        if(k == nums.Length) return nums;
        
        var indexes = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++) indexes[i] = i;
        
        Array.Sort(nums, indexes);
        
        int[] output = new int[k];
        int[] outputIndexes = new int[k];
        int index = 0;
        for(int i = nums.Length - k; i < nums.Length; i++)
        {
            output[index] = nums[i];
            outputIndexes[index] = indexes[i];
            index++;
        }
        
        Array.Sort(outputIndexes, output);
        
        return output;
    }
}