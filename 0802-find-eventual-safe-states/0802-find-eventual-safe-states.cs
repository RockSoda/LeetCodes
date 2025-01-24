public class Solution 
{
    public IList<int> EventualSafeNodes(int[][] graph) 
    {
        var terminals = new HashSet<int>();
        
        for(int i = 0; i < graph.Length; i++)
            if(graph[i].Length == 0) terminals.Add(i);
        
        for(int i = 0; i < graph.Length; i++)
        {
            var path = new HashSet<int>(graph[i]);
            
            if(path.IsSubsetOf(terminals)) terminals.Add(i);
        }
        
        var output = terminals.ToList();
        output.Sort();
        return output;
    }
}