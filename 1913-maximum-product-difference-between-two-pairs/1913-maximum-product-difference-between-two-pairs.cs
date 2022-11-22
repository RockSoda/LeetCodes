public class Solution 
{
    public int MaxProductDifference(int[] nums) 
    {
        var list = nums.ToList();
        var max1 = list.Max();
        list.Remove(max1);
        var max2 = list.Max();
        list.Remove(max2);
        var min1 = list.Min();
        list.Remove(min1);
        var min2 = list.Min();
        return (max1*max2)-(min1*min2);
    }
}