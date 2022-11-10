public class Solution 
{
    public bool IsPrefixString(string s, string[] words) 
    {
        var sb = new StringBuilder();
        foreach(var word in words)
        {
            sb.Append(word);
            if(!s.StartsWith(sb.ToString())) return false;
            
            if(s.Length == sb.Length) return true;
        }
        
        return s.Length == sb.Length;
    }
}