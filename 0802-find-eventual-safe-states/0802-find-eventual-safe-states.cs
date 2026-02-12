public class Solution 
{
    public IList<int> EventualSafeNodes(int[][] graph) 
    {
        var terminals = new HashSet<int>();
        
        for(int i = 0; i < graph.Length; i++)
            if(graph[i].Length == 0) terminals.Add(i);
        
        bool hasOperation = false;
        do
        {
            hasOperation = false;
            for(int i = 0; i < graph.Length; i++)
            {
                var path = new HashSet<int>(graph[i]);

                if(path.IsSubsetOf(terminals))
                    hasOperation = terminals.Add(i) || hasOperation;
            }
        }
        while(hasOperation);
        
        var output = terminals.ToList();
        output.Sort();
        return output;
    }
}