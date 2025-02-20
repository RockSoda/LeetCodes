public class Solution 
{
    public string FindDifferentBinaryString(string[] nums) 
    {
        var bits = nums.First().Length;
        var size = (int)Math.Pow(2, bits);
        var set = nums.ToHashSet();
        
        for (int i = 0; i < size; i++)
        {
            var curr = Convert.ToString(i, 2).PadLeft(bits, '0');
            if (!set.Contains(curr)) return curr;
        } 
        
        return string.Empty;
    }
}