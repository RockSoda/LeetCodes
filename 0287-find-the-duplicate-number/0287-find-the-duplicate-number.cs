public class Solution 
{
    public int FindDuplicate(int[] nums) =>
        nums.GroupBy(x => x).First(x => x.Count() > 1).Key;
}