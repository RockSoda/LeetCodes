public class Solution 
{
    private bool DFS(int[][] graph, int index, bool color, bool?[] colors)
    {
        if(colors[index] != null) return colors[index] == color;
        
        colors[index] = color;
        
        foreach(var node in graph[index])
        {
            if(!DFS(graph, node, !color, colors)) return false;
        }
        
        return true;
    }
    
    public bool IsBipartite(int[][] graph)
    {
        bool?[] colors = new bool?[graph.Length];
        
        for(int i = 0; i < graph.Length; i++)
        {
            if(colors[i] != null) continue;
            
            if(!DFS(graph, i, true, colors)) return false;
        }
        
        return true;
    }
}