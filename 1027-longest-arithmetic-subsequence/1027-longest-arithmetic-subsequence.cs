public class Solution 
{
    public int LongestArithSeqLength(int[] nums) 
    {
        int n = nums.Length;
        if (n <= 2) return n;
        
        int longest = 2;
        var map = new Dictionary<int, int>[n];
        for(int i = 0; i < n; i++)
        {
            map[i] = new Dictionary<int, int>();
            
            for (int j = 0; j < i; j++)
            {
                int diff = nums[i] - nums[j];
                map[i][diff] = map[j].ContainsKey(diff) ? map[j][diff]+1 : 2;
                longest = Math.Max(longest, map[i][diff]);
            }
        }
        return longest;
    }
}