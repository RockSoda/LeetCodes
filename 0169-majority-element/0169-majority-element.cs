public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
        var map = new Dictionary<int, int>();
        foreach(var num in nums)
        {
            map[num] = map.ContainsKey(num) ? map[num] + 1 : 1;
            if(map[num] > (nums.Length / 2)) return num;
        }
        
        return -1;
    }
}