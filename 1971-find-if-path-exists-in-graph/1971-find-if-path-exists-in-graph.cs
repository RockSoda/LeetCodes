public class Solution 
{
    private bool CanReach(Dictionary<int, HashSet<int>> map, HashSet<int> visited, int curr, int dst)
    {
        if(curr == dst) return true;
        if(!map.ContainsKey(curr) || visited.Contains(curr)) return false;
        
        visited.Add(curr);
        
        bool ans = false;
        foreach(var next in map[curr])
            ans = ans || CanReach(map, visited, next, dst);
        
        return ans;
    }
    
    public bool ValidPath(int n, int[][] edges, int source, int destination) 
    {
        var map = new Dictionary<int, HashSet<int>>();
        foreach(var edge in edges)
        {
            if(!map.ContainsKey(edge[0])) map[edge[0]] = new HashSet<int>();
            if(!map.ContainsKey(edge[1])) map[edge[1]] = new HashSet<int>();
            
            map[edge[0]].Add(edge[1]);
            map[edge[1]].Add(edge[0]);
        }
        
        return CanReach(map, new HashSet<int>(), source, destination);
    }
}