public class Solution 
{
    public string MostCommonWord(string paragraph, string[] banned) 
    {
        var arr = paragraph.Replace("!", " ").Replace("?", " ").Replace("\'", " ").Replace(",", " ").Replace(";", " ").Replace(".", " ").Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var set = banned.ToHashSet();

        var map = new Dictionary<string, int>();
        foreach(var word in arr)
        {
            var lower = word.ToLower();
            if(set.Contains(lower)) continue;

            if(!map.ContainsKey(lower)) map[lower] = 0;

            map[lower]++;
        }
        
        var max = 0;
        var output = string.Empty;
        foreach(var kvp in map)
        {
            if(kvp.Value <= max) continue;

            max = kvp.Value;
            output = kvp.Key;
        }
        return output;
    }
}