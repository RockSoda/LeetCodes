public class Solution 
{
    public int LongestBalanced(int[] nums) 
    {
        int maxLen = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            var odd = new HashSet<int>(), even = new HashSet<int>();
            for(int j = i; j < nums.Length; j++)
            {
                if(nums[j] % 2 == 0) even.Add(nums[j]);
                else odd.Add(nums[j]);

                if(odd.Count() == even.Count()) maxLen = Math.Max(maxLen, j-i+1);
            }
        }
        
        return maxLen;
    }
}