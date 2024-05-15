public class Solution 
{
    public int ArithmeticTriplets(int[] nums, int diff) 
    {
        // j - i = d
        // k - j = d
        // j - i = k - j
        // 2j = i + k
        
        var map = new Dictionary<int, HashSet<(int, int)>>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i; j < nums.Length; j++)
            {
                var sum = nums[i] + nums[j];
                
                if(!map.ContainsKey(sum)) map[sum] = new HashSet<(int, int)>();
                
                map[sum].Add((i, j));
            }
        }
        
        var output = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            var key = 2 * nums[i];
            if(!map.ContainsKey(key)) continue;
            
            foreach((int a, int b) pair in map[key])
            {
                if(pair.a == i || pair.b == i) continue;
                
                if((nums[i] - nums[pair.a] == diff && nums[pair.b] - nums[i] == diff) || 
                   (nums[i] - nums[pair.b] == diff && nums[pair.a] - nums[i] == diff)) 
                    output++;
            }
        }
        
        return output;
    }
}