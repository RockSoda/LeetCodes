public class Solution 
{
    public bool UniqueOccurrences(int[] arr) 
    {
        var map = new Dictionary<int, int>();
        foreach(var num in arr)
            map[num] = map.ContainsKey(num) ? map[num]+1 : 1;
        
        var set = new HashSet<int>();
        foreach(var freq in map.Values)
            if(!set.Add(freq)) return false;
        
        return true;
    }
}