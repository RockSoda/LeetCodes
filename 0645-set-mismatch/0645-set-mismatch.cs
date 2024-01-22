public class Solution 
{
    public int[] FindErrorNums(int[] nums) 
    {
        var output = new int[2];
        var map = new Dictionary<int, int>();
        
        foreach(var num in nums)
            map[num] = map.ContainsKey(num) ? map[num] + 1 : 1;
        
        for(int i = 1; i <= nums.Length; i++)
        {
            if(!map.ContainsKey(i)) output[1] = i;
            else if(map[i] > 1) output[0] = i;
            
            if(output[0] != 0 && output[1] != 0) break;
        }
        
        return output;
    }
}