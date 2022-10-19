public class Solution 
{
    public IList<string> TopKFrequent(string[] words, int k) 
    {
        var map = new Dictionary<string, int>();
        foreach(var word in words) map[word] = map.ContainsKey(word) ? map[word]+1 : 1;
        
        return map.OrderBy(x => -x.Value).ThenBy(x => x.Key).Take(k).Select(x => x.Key).ToList();
    }
}