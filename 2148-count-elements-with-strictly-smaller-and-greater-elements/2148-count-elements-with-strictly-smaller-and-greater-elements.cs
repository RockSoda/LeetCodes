public class Solution 
{
    public int CountElements(int[] nums) 
    {
        var list = nums.ToList();
        int max = list.Max(), min = list.Min(), counter = 0;
        list.ForEach(num => counter += num > min && num < max ? 1 : 0);
        return counter;
    }
}