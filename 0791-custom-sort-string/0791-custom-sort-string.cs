public class Solution 
{
    public string CustomSortString(string order, string s) 
    {
        var sb = new StringBuilder();
        var map = new Dictionary<char, int>();
        foreach(var c in s)
            map[c] = map.ContainsKey(c) ? map[c] + 1 : 1;
        
        foreach(var c in order)
        {
            if(!map.ContainsKey(c)) continue;
            
            sb.Append(c, map[c]);
            map.Remove(c);
        }
        
        foreach(var kvp in map)
            sb.Append(kvp.Key, kvp.Value);
        
        return sb.ToString();
    }
}