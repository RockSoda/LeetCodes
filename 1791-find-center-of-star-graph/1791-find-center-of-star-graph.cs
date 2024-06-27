public class Solution 
{
    public int FindCenter(int[][] edges) 
    {
        var map = new Dictionary<int, int>();
        
        int maxFreq = 0, val = -1;
        
        foreach(var edge in edges)
        {
            map[edge[0]] = map.ContainsKey(edge[0]) ? map[edge[0]]+1 : 1;
            map[edge[1]] = map.ContainsKey(edge[1]) ? map[edge[1]]+1 : 1;
            
            if(map[edge[0]] > maxFreq)
            {
                maxFreq = map[edge[0]];
                val = edge[0];
            }
            
            if(map[edge[1]] > maxFreq)
            {
                maxFreq = map[edge[1]];
                val = edge[1];
            }
        }
        
        return val;
    }
}