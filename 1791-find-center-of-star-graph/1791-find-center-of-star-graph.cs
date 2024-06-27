public class Solution 
{
    public int FindCenter(int[][] edges) 
    {
        var map = new Dictionary<int, int>();
        foreach(var edge in edges)
        {
            map[edge[0]] = map.ContainsKey(edge[0]) ? map[edge[0]]+1 : 1;
            map[edge[1]] = map.ContainsKey(edge[1]) ? map[edge[1]]+1 : 1;
        }
        
        var max = map.ToList().Max(kvp => kvp.Value);
        return map.ToList().Find(kvp => kvp.Value == max).Key;
    }
}