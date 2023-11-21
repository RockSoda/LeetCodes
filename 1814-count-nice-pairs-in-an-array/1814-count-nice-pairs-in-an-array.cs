public class Solution 
{
    private int MOD = (int)Math.Pow(10, 9) + 7;
    
    public int CountNicePairs(int[] nums) 
    {
        int rev(int num)
        {
            var str = num.ToString();
            return int.Parse(new string(str.Reverse().ToArray()));
        }
        
        //(nums[i] - rev(nums[i])) == (nums[j] - rev(nums[j]))
        
        var output = 0;
        var map = new Dictionary<int, int>();
        foreach (var num in nums) 
        {
            var key = num - rev(num);
            if (map.ContainsKey(key))
            {
                output = (output + map[key]) % MOD;
                map[key]++;
            }
            else map[key] = 1;
        }
        
        return output;
    }
}