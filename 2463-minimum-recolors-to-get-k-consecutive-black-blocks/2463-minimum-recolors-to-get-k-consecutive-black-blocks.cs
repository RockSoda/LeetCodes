public class Solution 
{
    public int MinimumRecolors(string blocks, int k) 
    {
        var min = blocks.Length;
        for(int i = k; i <= blocks.Length; i++)
        {
            var substr = blocks.Substring(i-k, k);
            min = Math.Min(min, substr.Count(c => c == 'W'));
        }
        return min;
    }
}