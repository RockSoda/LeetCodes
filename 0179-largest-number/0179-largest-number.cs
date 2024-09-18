public class Solution 
{
    public string LargestNumber(int[] nums) 
    {
        var strs = nums.Select(x => x.ToString()).ToArray();
        
        Array.Sort(strs, (x, y) => (y + x).CompareTo(x + y));
        
        if(strs[0][0] == '0') return "0";
        
        var sb = new StringBuilder();
        
        foreach(var str in strs) sb.Append(str);
        
        return sb.ToString();
    }
}