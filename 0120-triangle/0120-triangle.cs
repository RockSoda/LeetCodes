public class Solution 
{
    private Dictionary<(int, int), int> Memo = new Dictionary<(int, int), int>();

    public int MinimumTotal(IList<IList<int>> triangle, int idx = 0, int level = 0) 
    {
        if(Memo.ContainsKey((idx, level))) return Memo[(idx, level)];
        
        if(level >= triangle.Count) return 0;

        return Memo[(idx, level)] = triangle[level][idx] + Math.Min(MinimumTotal(triangle, idx, level+1), MinimumTotal(triangle, idx+1, level+1));
    }
}