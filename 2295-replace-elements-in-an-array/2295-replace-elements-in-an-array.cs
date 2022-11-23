public class Solution 
{
    public int[] ArrayChange(int[] nums, int[][] operations) 
    {
        var map = new Dictionary<int, List<int>>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(!map.ContainsKey(nums[i])) map[nums[i]] = new List<int>();
            
            map[nums[i]].Add(i);
        }
        
        foreach(var opr in operations)
        {
            var indexes = map[opr[0]];
            map.Remove(opr[0]);
            map[opr[1]] = indexes.ToList();
        }
        
        foreach(var kvp in map)
        {
            foreach(var index in kvp.Value)
                nums[index] = kvp.Key;
        }
        
        return nums;
    }
}