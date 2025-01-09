public class Solution 
{
    public int PrefixCount(string[] words, string pref) => words.Count(word => word.StartsWith(pref));
}