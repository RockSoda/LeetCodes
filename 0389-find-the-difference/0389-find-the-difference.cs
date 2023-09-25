public class Solution 
{
    public char FindTheDifference(string s, string t) 
    {
        var map = new int[26];
        
        foreach(var c in s) map[c-'a']++;
        
        foreach(var c in t) if(--map[c-'a'] < 0) return c;
        
        return '-';
    }
}