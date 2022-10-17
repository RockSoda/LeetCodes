public class Solution 
{
    public bool CheckIfPangram(string sentence) 
    {
        var map = new bool[26];
        foreach(var c in sentence) map[c-'a'] = true;
        
        return map.Count(c => c) == 26;
    }
}