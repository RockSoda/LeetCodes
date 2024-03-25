public class Solution 
{
    public string DecodeMessage(string key, string message) 
    {
        var codex = new int[26];
        var visited = new HashSet<char>();
        int idx = 0;
        foreach(var c in key)
        {
            if(c == ' ' || visited.Contains(c)) continue;

            visited.Add(c);
            codex[c - 'a'] = idx++;
        }
        
        var sb = new StringBuilder();
        foreach(var c in message)
        {
            if(c == ' ') sb.Append(" ");
            else sb.Append((char)(codex[c-'a']+'a'));
        }
        
        return sb.ToString();
    }
}