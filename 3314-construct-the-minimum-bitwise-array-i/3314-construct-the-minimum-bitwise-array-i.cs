public class Solution 
{
    public int[] MinBitwiseArray(IList<int> nums) 
    {
        var output = new int[nums.Count];
        Array.Fill(output, -1);
        for(int i = 0; i < nums.Count; i++)
        {
            for(int j = 1; j <= nums[i]; j++)
            {
                if((int)(j|(j+1)) != nums[i]) continue;
                output[i] = j;
                break;
            }
        }
        return output;
    }
}