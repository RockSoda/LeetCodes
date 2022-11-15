public class Solution 
{
    private bool Recurse(string s, IList<string> wordDict, string curr, Dictionary<string, bool> memo)
    {
        if(memo.ContainsKey(curr)) return memo[curr];
        
        if(string.Equals(s, curr)) return true;
        
        if(s.Length <= curr.Length) return false;
        
        bool ans = false;
        foreach(var word in wordDict) 
            if(s.StartsWith(curr+word)) ans = ans || Recurse(s, wordDict, curr+word, memo);
        
        return memo[curr] = ans;
    }
    
    public bool WordBreak(string s, IList<string> wordDict) 
    {
        var memo = new Dictionary<string, bool>();
        return Recurse(s, wordDict, "", memo);
    }
}