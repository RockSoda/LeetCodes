public class Solution 
{
    public bool DivideArray(int[] nums) 
    {
        var map = new Dictionary<int, int>();
        foreach(var num in nums) map[num] = map.ContainsKey(num) ? map[num]+1 : 1;

        return !map.Any(kvp => (kvp.Value & 1) == 1);
    }
}