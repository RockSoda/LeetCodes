public class Solution 
{
    public int CountCompleteSubarrays(int[] nums) 
    {
        var numOfDistinct = nums.Distinct().Count();
        
        var ans = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            var set = new HashSet<int>();
            for(int j = i; j < nums.Length; j++)
            {
                set.Add(nums[j]);
                if(set.Count == numOfDistinct)
                {
                    ans += nums.Length - j;
                    break;
                }
            }
        }
        return ans;
    }
}