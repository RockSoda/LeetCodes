public class Solution 
{
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) 
    {
        var output = new List<int>();
        
        var intEdges = new int[n];
        
        foreach(var edge in edges)
            intEdges[edge[1]]++;
        
        for(int i = 0; i < n; i++)
            if(intEdges[i] == 0) output.Add(i);
        
        return output;
    }
}