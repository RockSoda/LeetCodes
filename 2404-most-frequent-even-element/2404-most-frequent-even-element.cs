public class Solution 
{
    public int MostFrequentEven(int[] nums) 
    {
        var evenKvp = nums.Where(x => x % 2 == 0).GroupBy(x => x).Select(x => new { num = x.Key, freq = x.Count() });
        
        if(evenKvp.Count() == 0) return -1;
        
        var maxVal = evenKvp.Max(x => x.freq);
        var maxNum = evenKvp.Where(x => x.freq == maxVal);
        return maxNum.Min(x => x.num);
    }
}