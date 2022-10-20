public class Solution 
{
    public int[] Shuffle(int[] nums, int n) 
    {
        var output = new List<int>();
        int half = nums.Length / 2;
        
        for(int i = 0; i < half; i++)
        {
            int j = half + i;
            output.Add(nums[i]);
            output.Add(nums[j]);
        }
        
        return output.ToArray();
    }
}