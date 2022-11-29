public class Solution 
{
    public IList<int> FindDuplicates(int[] nums) 
    {
        var output = new List<int>();
        var set = new HashSet<int>();
        foreach(var num in nums)
            if(!set.Add(num)) output.Add(num);
        
        return output;
    }
}