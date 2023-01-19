public class Solution 
{
    public int SubarraysDivByK(int[] nums, int k) 
    {
        int count = 0;
        Dictionary<int, int> remaindersCountSet = new Dictionary<int, int>();
        remaindersCountSet[0] = 1;
        int sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            var remainder = sum % k;
            remainder = remainder < 0 ? remainder+k : remainder;
            sum = remainder;

            if(remaindersCountSet.ContainsKey(remainder))
            {
                count += remaindersCountSet[remainder];
                remaindersCountSet[remainder]++;
            }
            else remaindersCountSet[remainder] = 1;
        }

        return count;
    }
}