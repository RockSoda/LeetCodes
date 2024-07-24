public class Solution 
{
    public int[] SortJumbled(int[] mapping, int[] nums) 
    {
        var map = new Dictionary<(int decoded, int idx), int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var sb = new StringBuilder();
            foreach(var c in num.ToString()) sb.Append(mapping[c-'0']);
            map[(int.Parse(sb.ToString()), i)] = num;
        }
        
        return map.OrderBy(kvp => kvp.Key.decoded).ThenBy(kvp => kvp.Key.idx).Select(kvp => kvp.Value).ToArray();
    }
}