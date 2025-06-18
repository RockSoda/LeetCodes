public class Solution 
{
    public int[][] DivideArray(int[] nums, int k) 
    {
        Array.Sort(nums);
        int groupIndex = 0, size = nums.Length;
        var result = new int[size / 3][];
        
        for (int i = 0; i < size; i += 3) 
        {
            if (i + 2 >= size || nums[i + 2] - nums[i] > k) return new int[0][];
            
            result[groupIndex] = new int[]{ nums[i], nums[i + 1], nums[i + 2] };
            groupIndex++;
        }
        
        return result;
    }
}