public class Solution 
{
    public int XorAfterQueries(int[] nums, int[][] queries) 
    {
        var mod = 1_000_000_007;
        void ProcessQuery(int[] query)
        {
            for(int i = query[0]; i <=query[1]; i += query[2]) 
                nums[i] = (int)((long)nums[i] * query[3] % mod);
        }

        foreach(var query in queries) ProcessQuery(query);

        var output = nums.First();
        for(int i = 1; i < nums.Length; i++) output ^= nums[i];
        return output;
    }
}