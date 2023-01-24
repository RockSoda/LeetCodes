public class Solution 
{
    public int FindSpecialInteger(int[] arr) 
    {
        var group = arr.GroupBy(x => x);
        var maxFreq = group.Max(x => x.Count());
        return group.Where(x => x.Count() == maxFreq).Select(x => x.Key).First();
    }
}