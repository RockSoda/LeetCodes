public class Solution 
{
    public int MinimizeMax(int[] nums, int p) 
    {
        Array.Sort(nums);
        int left = 0, right = nums.Last() - nums.First();
        
        bool IsValidInterval(int threshold)
        {
            int counter = 0;
            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] - nums[i-1] > threshold) continue;

                counter++;
                i++;
            }
            return counter >= p;
        }

        while(left < right)
        {
            int mid = left + (right - left) / 2;
            if(IsValidInterval(mid)) right = mid;
            else left = mid + 1;
        }
        return left;
    }
}