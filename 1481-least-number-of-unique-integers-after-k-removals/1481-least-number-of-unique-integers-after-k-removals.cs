public class Solution 
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k) 
    {
        var map = new Dictionary<int, int>();
        foreach(var num in arr)
            map[num] = map.ContainsKey(num) ? map[num]+1 : 1;
        
        var freqs = map.Values.ToArray();
        Array.Sort(freqs);
        for(int i = 0; i < freqs.Length; i++)
        {
            if(freqs[i] < k) k -= freqs[i];
            else if(freqs[i] > k) return freqs.Length - i;
            else return freqs.Length - i - 1;
        }
        
        return -1;
    }
}