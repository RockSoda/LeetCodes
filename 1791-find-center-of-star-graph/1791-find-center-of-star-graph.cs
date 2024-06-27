public class Solution 
{
    public int FindCenter(int[][] edges) 
    {
        var map = new Dictionary<int, int>();
        
        int maxFreq = 0, val = -1;
        
        void ProcessEdge(int edge)
        {
            map[edge] = map.ContainsKey(edge) ? map[edge]+1 : 1;
            
            if(map[edge] > maxFreq)
            {
                maxFreq = map[edge];
                val = edge;
            }
        }
        
        foreach(var edge in edges)
        {
           ProcessEdge(edge[0]);
           ProcessEdge(edge[1]);
        }
        
        return val;
    }
}