public class Solution 
{
    public int MinimumOperations(int[] nums) 
    {
        var map = new Dictionary<int, int>();
        foreach(var num in nums) map[num] = map.ContainsKey(num) ? map[num]+1 : 1;
        
        foreach(var key in map.Keys.ToList())
        {
            if(map[key] == 1) map.Remove(key);
        }

        void CheckAndRemoveKeyFromMap(int key)
        {
            if(!map.ContainsKey(key)) return;
            
            if(--map[key] == 1) map.Remove(key);
        }

        var oprs = 0;
        for(int i = 2; i < nums.Length; i += 3)
        {
            if(map.Count <= 0) break;

            CheckAndRemoveKeyFromMap(nums[i-2]);
            CheckAndRemoveKeyFromMap(nums[i-1]);
            CheckAndRemoveKeyFromMap(nums[i]);

            oprs++;
        }

        if(map.Count > 0) oprs++;
        return oprs;
    }
}