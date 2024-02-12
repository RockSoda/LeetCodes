public class Solution 
{
    private int GetMax(int a, int b, int c, int d, int e, int f, int g, int h, int i)=>
        Math.Max(Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, d)), Math.Max(Math.Max(e, f), Math.Max(g, h))), i);
    
    private int DP(int[][] grid, int i, int j1, int j2, Dictionary<(int, int, int), int> memo)
    {
        if(i < 0 || i >= grid.Length ||  j1 < 0 || j1 >= grid[i].Length || j2 < 0 || j2 >= grid[i].Length)
            return -9999999;
        
        if(memo.ContainsKey((i, j1, j2))) return memo[(i, j1, j2)];
        
        int curr1 = grid[i][j1];
        int curr2 = grid[i][j2];
        
        if(j1 == j2) curr2 = 0;
        
        if(i == grid.Length-1) return curr1+curr2;
        
        return memo[(i, j1, j2)] = GetMax(
            DP(grid, i+1, j1-1, j2-1, memo)+curr1+curr2,
            DP(grid, i+1, j1-1, j2, memo)+curr1+curr2,
            DP(grid, i+1, j1-1, j2+1, memo)+curr1+curr2,
            DP(grid, i+1, j1, j2-1, memo)+curr1+curr2,
            DP(grid, i+1, j1, j2, memo)+curr1+curr2,
            DP(grid, i+1, j1, j2+1, memo)+curr1+curr2,
            DP(grid, i+1, j1+1, j2-1, memo)+curr1+curr2,
            DP(grid, i+1, j1+1, j2, memo)+curr1+curr2,
            DP(grid, i+1, j1+1, j2+1, memo)+curr1+curr2);
    }
    
    public int CherryPickup(int[][] grid) 
    {
        var memo = new Dictionary<(int, int, int), int>();
        
        return DP(grid, 0, 0, grid[0].Length-1, memo);
    }
}