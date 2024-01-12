public class Solution 
{
    public bool HalvesAreAlike(string s) 
    {
        var vowels = new HashSet<char>{'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};
        var half = s.Length/2;
        var a = s.Take(half);
        var b = s.Skip(half).Take(half);
        
        return a.Count(c => vowels.Contains(c)) == b.Count(c => vowels.Contains(c));
    }
}