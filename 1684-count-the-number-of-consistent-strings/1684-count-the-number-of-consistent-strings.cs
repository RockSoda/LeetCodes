public class Solution 
{
    public int CountConsistentStrings(string allowed, string[] words) 
    {
        var set = new HashSet<char>(allowed);
        return words.Count(word => word.All(c => set.Contains(c)));
    }
}