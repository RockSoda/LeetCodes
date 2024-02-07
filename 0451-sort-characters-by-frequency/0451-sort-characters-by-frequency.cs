public class Solution 
{
    public string FrequencySort(string s) 
    {
        var map = new Dictionary<char, int>();
        foreach(var c in s)
            map[c] = map.ContainsKey(c) ? map[c]+1 : 1;
        
        var kvpList = map.OrderByDescending(kvp => kvp.Value).ToList();
        
        var sb = new StringBuilder();
        foreach(var kvp in kvpList)
            sb.Append(kvp.Key, kvp.Value);
        
        return sb.ToString();
    }
}