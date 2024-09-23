public class Solution 
{
    private int Recurse(string s, string[] dict, Dictionary<(string str, string dict), int> memo, Dictionary<string, int> map)
    {
        if(string.IsNullOrEmpty(s)) return 0;
        
        if(map.ContainsKey(s)) return map[s];

        foreach(var val in dict)
        {
            if (memo.ContainsKey((s, val))) continue;

            var skipped = Recurse(s.Substring(1, s.Length-1), dict, memo, map) + 1;
            var took = s.StartsWith(val) ? 
                       Recurse(s.Substring(val.Length, s.Length-val.Length), dict, memo, map) : 
                       int.MaxValue;
            
            memo[(s, val)] = Math.Min(skipped, took);
            map[s] = map.ContainsKey(s) ? Math.Min(memo[(s, val)], map[s]) : memo[(s, val)];
        }

        return map[s];
    }

    public int MinExtraChar(string s, string[] dictionary) 
    {
        var memo = new Dictionary<(string, string), int>();
        
        return Recurse(s, dictionary, memo, new Dictionary<string, int>());
    }
}