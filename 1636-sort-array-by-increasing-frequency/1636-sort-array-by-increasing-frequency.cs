public class Solution 
{
    public int[] FrequencySort(int[] nums) 
    {
        var output = new int[nums.Length];
        var map = new Dictionary<int, int>();
        foreach(var num in nums)
            map[num] = map.ContainsKey(num) ? map[num]+1 : 1;
        
        var ordered = map.OrderBy(kvp => kvp.Value).ThenByDescending(kvp => kvp.Key);
        
        int idx = 0;
        foreach(var kvp in ordered)
        {
            for(int i = 0; i < kvp.Value; i++)
                output[idx++] = kvp.Key;
        }
        return output;
    }
}