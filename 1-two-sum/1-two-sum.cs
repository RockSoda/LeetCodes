public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        var map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int remaind = target - nums[i];
            if(map.ContainsKey(remaind)) return new int[]{ map[remaind], i};
            
            map[nums[i]] = i;
        }
        
        return new int[]{ -1, -1 };
    }
}