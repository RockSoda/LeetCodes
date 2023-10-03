public class Solution 
{
    public int NumIdenticalPairs(int[] nums) 
    {
        var map = new Dictionary<int, int>();
        nums.ToList().ForEach(num => map[num] = map.ContainsKey(num) ? map[num]+1 : 1);
        
        var counter = 0;
        map.ToList().ForEach(kvp => counter += kvp.Value*(kvp.Value-1)/2);
        
        return counter;
    }
}