public class Solution 
{
    public int MaxFrequencyElements(int[] nums) 
    {
        var map = new Dictionary<int, int>();
        foreach(var num in nums)
            map[num] = map.ContainsKey(num) ? map[num]+1 : 1;
        
        var max = map.Values.Max();
        var occurrence = map.Values.Count(num => num == max);
        return occurrence * max;
    }
}