public class Solution 
{
    private void Recurse(string s, IList<string> wordDict, string curr, string formatted, IList<string> output, HashSet<string> memo)
    {
        if(memo.Contains(formatted)) return;
        
        if(string.Equals(s, curr))
        {
            output.Add(formatted[1..]);
            return;
        }
        
        if(s.Length <= curr.Length) return;
        
        foreach(var word in wordDict)
        {
            if(s.StartsWith(curr+word))
            {
                Recurse(s, wordDict, curr+word, formatted+" "+word, output, memo);
                memo.Add(formatted+" "+word);
            }
        }
    }
    
    public IList<string> WordBreak(string s, IList<string> wordDict) 
    {
        var output = new List<string>();
        Recurse(s, wordDict, "", "", output, new HashSet<string>());
        return output;
    }
}