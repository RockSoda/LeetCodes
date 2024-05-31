public class Solution 
{
    public int[] SingleNumber(int[] nums) 
    {
        var set = new HashSet<int>();
        var setOfDup = new HashSet<int>();
        
        foreach(var num in nums)
            if(!set.Add(num)) setOfDup.Add(num);
        
        set.ExceptWith(setOfDup);
        return set.ToArray();
    }
}