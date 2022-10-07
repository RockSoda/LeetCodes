public class Solution 
{
    private int GetFreq(string str)
    {
        var map = new int[26];
        foreach(var c in str) map[c-'a']++;
        
        foreach(var freq in map)
            if(freq != 0) return freq;
        
        return 0;
    }
    
    private int[] ConvertStrArrToIntFreqArr(string[] strs)
    {
        var output = new int[strs.Length];
        for(int i = 0; i < strs.Length; i++)
            output[i] = GetFreq(strs[i]);
        
        return output;
    }
    
    public int[] NumSmallerByFrequency(string[] queries, string[] words) 
    {
        var freqQueries = ConvertStrArrToIntFreqArr(queries);
        var freqWords = ConvertStrArrToIntFreqArr(words);
        
        var output = new int[freqQueries.Length];
        for(int i = 0; i < freqQueries.Length; i++)
            output[i] = freqWords.Count(wFreq => wFreq > freqQueries[i]);
        
        return output;
    }
}