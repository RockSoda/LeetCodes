public class Solution 
{
    public int CountLargestGroup(int n) 
    {
        int GetSum(int num)
        {
            int ans = 0;
            while(num > 0)
            {
                ans += num % 10;
                num /= 10;
            }
            return ans;
        }

        var map = new Dictionary<int, int>();
        var largestSize = 0;
        for(int i = 1; i <= n; i++)
        {
            var val = GetSum(i);
            map[val] = map.ContainsKey(val) ? map[val]+1 : 1;
            largestSize = Math.Max(largestSize, map[val]);
        }

        return map.Count(kvp => kvp.Value == largestSize);
    }
}