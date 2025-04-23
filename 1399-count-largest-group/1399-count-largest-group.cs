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
            freqMap[kvp.Value] = freqMap.ContainsKey(kvp.Value) ? freqMap[kvp.Value]+1 : 1;
            maxSize = Math.Max(maxSize, kvp.Value);
        }

        return freqMap[maxSize];
    }
}