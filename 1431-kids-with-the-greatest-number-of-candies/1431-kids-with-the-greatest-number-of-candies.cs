public class Solution 
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        var max = candies.Max();
        var list = new List<bool>();
        foreach(var candy in candies)
            list.Add(candy + extraCandies >= max);
        
        return list;
    }
}