public class Solution 
{
    public int LargestCombination(int[] candidates) 
    {
        var bitMap = new bool[24][];
        for(int i = 0; i < 24; i++)
            bitMap[i] = new bool[candidates.Length];
        
        for(int i = 0; i < candidates.Length; i++)
        {
            var bin = Convert.ToString(candidates[i], 2);
            int idx = 0;
            for(int j = bin.Length-1; j >= 0; j--)
                bitMap[idx++][i] = bin[j] == '1';
        }
        
        var max = 0;
        foreach(var bit in bitMap)
            max = Math.Max(bit.Count(b => b), max);
        return max;
    }
}