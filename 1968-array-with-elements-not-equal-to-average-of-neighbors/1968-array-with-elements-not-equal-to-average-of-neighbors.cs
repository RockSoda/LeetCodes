public class Solution 
{
    public int[] RearrangeArray(int[] nums) 
    {
        Array.Sort(nums);
        double median = nums.Length % 2 == 0 ? (double)(nums[nums.Length/2 - 1] + nums[nums.Length/2])/2 : nums[nums.Length/2];
        
        var output = new int[nums.Length];
        int oddIdx = 1, evenIdx = 0;
        foreach(var num in nums)
        {
            if(num < median) 
            {
                output[oddIdx] = num;
                oddIdx += 2;
            }
            else 
            {
                output[evenIdx] = num;
                evenIdx += 2;
            }
        }
        return output;
    }
}