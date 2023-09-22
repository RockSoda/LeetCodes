public class Solution 
{
    public bool IsSubsequence(string s, string t) 
    {
        int sIndex = 0;
        foreach(var c in t)
        {
            if(sIndex >= s.Length) break;
            
            if(c == s[sIndex]) sIndex++;
        }
        
        return sIndex >= s.Length;
    }
}