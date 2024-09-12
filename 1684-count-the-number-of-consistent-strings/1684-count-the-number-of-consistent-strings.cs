public class Solution 
{
    public int CountConsistentStrings(string allowed, string[] words) 
    {
        var set = new HashSet<char>();
        foreach(var c in allowed) set.Add(c);
        
        var counter = 0;
        foreach(var word in words)
        {
            if(word.ToHashSet().IsSubsetOf(set)) counter++;
        }
        return counter;
    }
}