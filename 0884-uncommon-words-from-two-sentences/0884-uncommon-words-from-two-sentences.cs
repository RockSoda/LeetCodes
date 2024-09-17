public class Solution 
{
    public string[] UncommonFromSentences(string s1, string s2) 
    {
        var arr = (s1 + " " + s2).Split(' ');
        var map = new Dictionary<string, int>();
        foreach(var word in arr)
            map[word] = map.ContainsKey(word) ? map[word]+1 : 1;
        return map.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).ToArray();
    }
}