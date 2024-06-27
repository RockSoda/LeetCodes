public class Solution 
{
    public int FindCenter(int[][] edges) 
    {
        var set = new HashSet<int>();
        var map = new Dictionary<int, int>();
        foreach(var edge in edges)
        {
            set.Add(edge[0]);
            set.Add(edge[1]);
            
            map[edge[0]] = map.ContainsKey(edge[0]) ? map[edge[0]]+1 : 1;
            map[edge[1]] = map.ContainsKey(edge[1]) ? map[edge[1]]+1 : 1;
        }
        
        return map.ToList().Find(kvp => kvp.Value == set.Count - 1).Key;
    }
}