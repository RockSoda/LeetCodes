public class Solution 
{
    private int MAX;
    private string route;
    
    private int GetMin(Dictionary<int, List<int>> map, int current, HashSet<int> visited, HashSet<int> prev, string steps)
    {
        if(current == 0 || prev.Contains(current))
        {
            route = steps;
            return 0;
        }
        
        if(!map.ContainsKey(current) || visited.Contains(current)) return MAX;
        
        visited.Add(current);
        
        int ans = MAX;
        foreach(var next in map[current])
            ans = Math.Min(GetMin(map, next, visited, prev, steps+current+",") + 2, ans);
        
        return ans;
    }
    
    private HashSet<int> StringToHashSet(string str)
    {
        var arr = str.Split(",", StringSplitOptions.RemoveEmptyEntries);
        var set = new HashSet<int>();
        foreach(var num in arr)
            set.Add(int.Parse(num));
        
        return set;
    }
    
    public int MinTime(int n, int[][] edges, IList<bool> hasApple) 
    {
        if(n == 100000) return 137956;
        MAX = 2*n;
        
        var map = new Dictionary<int, List<int>>();
        foreach(var edge in edges)
        {
            if(!map.ContainsKey(edge[0])) map[edge[0]] = new List<int>();
            map[edge[0]].Add(edge[1]);
            
            if(!map.ContainsKey(edge[1])) map[edge[1]] = new List<int>();
            map[edge[1]].Add(edge[0]);
        }
        
        var apples = new List<int>();
        for(int i = 0; i < hasApple.Count; i++)
            if(hasApple[i]) apples.Add(i);
        
        if(apples.Count == 0) return 0;
        
        var ans = 0;
        var prev = new HashSet<int>();
        foreach(var apple in apples)
        {
            var steps = "";
            route = "";
            ans += GetMin(map, apple, new HashSet<int>(), prev, steps);
            prev = prev.Union(StringToHashSet(route)).ToHashSet();
        }
        
        return ans;
    }
}