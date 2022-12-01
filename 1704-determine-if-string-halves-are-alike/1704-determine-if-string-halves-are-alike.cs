public class Solution 
{
    public bool HalvesAreAlike(string s) 
    {
        var vowels = new HashSet<char>{'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};
        var a = new List<char>();
        var b = new List<char>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(i < s.Length / 2) a.Add(s[i]);
            else b.Add(s[i]);
        }
        
        return a.Count(c => vowels.Contains(c)) == b.Count(c => vowels.Contains(c));
    }
}