public class Solution 
{
    public int MinOperations(int[] nums) 
    {
        var map = new Dictionary<int, int>();
        foreach(var num in nums)
            map[num] = map.ContainsKey(num) ? map[num]+1 : 1;
        
        var opr = 0;
        foreach(var kvp in map)
        {
            var freq = kvp.Value;
            if(freq < 2) return -1;
            
            var remainder = freq % 3;
            
            opr += (freq / 3) + (remainder == 0 ? 0 : 1);
        }
        
        return opr;
    }
}