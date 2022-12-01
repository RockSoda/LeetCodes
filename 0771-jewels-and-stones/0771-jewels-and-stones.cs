public class Solution 
{
    public int NumJewelsInStones(string jewels, string stones) 
    {
        var jewelSet = new HashSet<char>();
        foreach(var c in jewels) jewelSet.Add(c);
        
        var counter = 0;
        foreach(var c in stones) if(jewelSet.Contains(c)) counter++;
        
        return counter;
    }
}