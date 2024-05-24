public class Solution 
{
    public long FindTheArrayConcVal(int[] nums) 
    {
        bool isEven = nums.Length % 2 == 0;
        long concat = 0;
        
        for(int i = 0; i < nums.Length / 2; i++)
        {
            int backIdx = nums.Length - i - 1;
            concat += (long)Convert.ToDouble(nums[i].ToString() + nums[backIdx].ToString());
        }
        
        return isEven ? concat : concat + nums[nums.Length / 2];
    }
}