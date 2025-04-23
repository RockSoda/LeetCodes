public class Solution 
{
    public int CountLargestGroup(int n) 
    {
        int GetSumOfDigits(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        var map = new Dictionary<int, int>();
        for(int i = 1; i <= n; i++)
        {
            var sumOfDigits = GetSumOfDigits(i);
            map[sumOfDigits] = map.ContainsKey(sumOfDigits) ? map[sumOfDigits]+1 : 1;
        }
        
        var maxSize = -1;
        var freqMap = new Dictionary<int, int>();
        foreach(var kvp in map)
        {
            var key = kvp.Value;
            freqMap[key] = freqMap.ContainsKey(key) ? freqMap[key]+1 : 1;
            maxSize = Math.Max(maxSize, key);
        }

        return freqMap[maxSize];
    }
}