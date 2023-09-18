public class Solution 
{
    public int[] KWeakestRows(int[][] mat, int k) 
    {
        var map = new Dictionary<int, int>();
        for(int i = 0; i < mat.Length; i++)
            map[i] = mat[i].Count(cell => cell == 1);
        
        return map.OrderBy(kvp => kvp.Value).ThenBy(kvp => kvp.Key).Select(kvp => kvp.Key).Take(k).ToArray();
    }
}