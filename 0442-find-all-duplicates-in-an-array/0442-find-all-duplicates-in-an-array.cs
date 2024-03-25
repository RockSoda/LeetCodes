public class Solution 
{
    public IList<int> FindDuplicates(int[] nums) =>
        nums.GroupBy(num => num).
             Select(val => new { Key = val.Key, Count = val.Count() }).
             Where(kvp => kvp.Count > 1).
             Select(kvp => kvp.Key).ToList();
}