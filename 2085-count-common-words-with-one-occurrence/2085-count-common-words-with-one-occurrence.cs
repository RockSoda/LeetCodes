public class Solution 
{
    public int CountWords(string[] words1, string[] words2) 
    {
        HashSet<string> GetDictionaryThenSet(string[] words)
        {
            var map = new Dictionary<string, int>();
            foreach(var word in words)
                map[word] = map.ContainsKey(word) ? map[word]+1 : 1;

            return map.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).ToHashSet();
        }
        
        return  GetDictionaryThenSet(words1).Intersect(GetDictionaryThenSet(words2)).Count();
    }
}