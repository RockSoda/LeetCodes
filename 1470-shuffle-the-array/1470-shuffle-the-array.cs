public class Solution 
{
    public int[] Shuffle(int[] nums, int n) 
    {
        var output = new List<int>();
        
        for(int i = 0; i < n; i++)
        {
            int j = n + i;
            output.Add(nums[i]);
            output.Add(nums[j]);
        }
        
        return output.ToArray();
    }
}