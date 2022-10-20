public class Solution 
{
    public int[] Shuffle(int[] nums, int n) 
    {
        var output = new int[n*2];
        
        int index = 0;
        for(int i = 0; i < n; i++)
        {
            int j = n + i;
            output[index++] = nums[i];
            output[index++] = nums[j];
        }
        
        return output;
    }
}