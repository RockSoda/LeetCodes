public class Solution 
{
    public int[] NumberOfPairs(int[] nums) 
    {
        int pairs = 0;
        var map = new Dictionary<int, int>();
        
        foreach(var num in nums)
            map[num] = map.ContainsKey(num) ? map[num]+1 : 1;
        
        foreach(var kvp in map.ToList())
        {
            var freq = kvp.Value;
            var pair = freq / 2;
            
            pairs += pair;
            freq %= 2;
            
            if (freq == 0) map.Remove(kvp.Key);
            else map[kvp.Key] = freq;
        }
        
        return new int[]{ pairs, map.Values.Sum() };
    }
}