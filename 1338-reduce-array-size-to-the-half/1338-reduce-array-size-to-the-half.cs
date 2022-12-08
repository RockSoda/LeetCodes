public class Solution 
{
    public int MinSetSize(int[] arr) 
    {
        var map = new Dictionary<int, int>();
        foreach(var num in arr)
            map[num] = map.ContainsKey(num) ? map[num]+1 : 1;
        
        var freq = map.Values.ToList();
        freq.Sort();
        
        var sum = 0;
        var counter = 0;
        for(int i = freq.Count - 1; i >= 0; i--)
        {
            if(sum >= arr.Length/2) break;
            
            sum += freq[i];
            counter++;
        }
        
        return counter;
    }
}