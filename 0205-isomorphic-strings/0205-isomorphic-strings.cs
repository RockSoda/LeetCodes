public class Solution 
{
    public bool IsIsomorphic(string s, string t) 
    {
        if (s.Length != t.Length) return false;
        
        var maps = new Dictionary<char, char>();
        var mapt = new Dictionary<char, char>();
        
        for (int i = 0; i < s.Length; i++)
        {
            char sc = s[i], tc = t[i];
            
            if(maps.ContainsKey(sc) && maps[sc] != tc) return false;
            if(mapt.ContainsKey(tc) && mapt[tc] != sc) return false;
            
            maps[sc] = tc;
            mapt[tc] = sc;
        }
        
        return true;
    }
}