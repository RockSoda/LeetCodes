public class Solution 
{
    public int[][] DivideArray(int[] nums, int k) 
    {
        Array.Sort(nums);
        int size = nums.Length;
        var result = new List<int[]>();
        
        for (int i = 0; i < size; i += 3) 
        {
            if (i + 2 < size && nums[i + 2] - nums[i] <= k) 
                result.Add(new int[]{ nums[i], nums[i + 1], nums[i + 2] });
            else return new int[0][];
        }
        
        return result.ToArray();
    }
}