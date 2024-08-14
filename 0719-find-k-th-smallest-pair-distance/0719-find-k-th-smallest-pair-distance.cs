public class Solution 
{
    private int CountPairs(int[] nums, int dist)
    {
        int count = 0, left = 0;
        for(int right = 0; right < nums.Length && right >= left; right++)
        {
            while(nums[right] - nums[left] > dist) left++;
            
            count += right - left;
        }
        return count;
    }
    
    public int SmallestDistancePair(int[] nums, int k) 
    {
        Array.Sort(nums);
        
        int left = 0, right = nums.Last() - nums.First();
        
        while(left < right)
        {
            int mid = left + (right - left) / 2;
            
            int count = CountPairs(nums, mid);
            
            if(count < k) left = mid + 1;
            else right = mid;
        }
        
        return left;
    }
}