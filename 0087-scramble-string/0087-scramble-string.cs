public class Solution 
{
    Dictionary<string, bool> map = new Dictionary<string, bool>();
    
    public bool IsScramble(string s1, string s2) 
    {
        if(s1.Length != s2.Length) return false;
        if(s1 == s2) return true;
        
        if(s1.Length == 1) return false;
        
        var key = s1+s2;
        if(map.ContainsKey(key)) return map[key];
        
        for(int i = 1; i < s1.Length; i++)
        {
            bool isNotSwapped = IsScramble(s1.Substring(0, i), s2.Substring(0, i)) && IsScramble(s1.Substring(i), s2.Substring(i));
            
            if(isNotSwapped) 
            {
                map[key] = true;
                return true;
            }
            
            bool isSwapped = IsScramble(s1.Substring(0, i), s2.Substring(s2.Length - i)) && IsScramble(s1.Substring(i), s2.Substring(0, s2.Length - i));
            
            if(isSwapped)
            {
                map[key] = true;
                return true;
            }
        }
        
        map[key] = false;
        return false;
    }
}