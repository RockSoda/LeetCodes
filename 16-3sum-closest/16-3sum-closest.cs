public class Solution 
{
    public int ThreeSumClosest(int[] nums, int target) 
    {
        int result = nums[0] + nums[1] + nums[nums.Length-1];
        Array.Sort(nums);
        for(int i = 0; i < nums.Length-2; i++)
        {
            int left = i+1;
            int right = nums.Length-1;
            while(left < right)
            {
                int curr = nums[i] + nums[left] + nums[right];
                if(curr > target) right--;
                else left++;
                
                if(Math.Abs(curr - target) < Math.Abs(result - target)) result = curr;
            }
        }
        
        return result;
    }
}