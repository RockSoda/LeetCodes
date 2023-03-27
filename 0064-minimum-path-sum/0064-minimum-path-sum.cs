public class Solution 
{
    private int Helper(int[][] grid, int i, int j, int[][] memo)
    {
        if(i == grid.Length-1 && j == grid[i].Length-1) return grid[i][j];
        
        if(memo[i][j] != -1) return memo[i][j];
        
        if(i == grid.Length-1) 
            return memo[i][j] = grid[i][j] + Helper(grid, i, j+1, memo);
        
        if(j == grid[i].Length-1) 
            return memo[i][j] = grid[i][j] + Helper(grid, i+1, j, memo);
        
        return memo[i][j] = Math.Min(grid[i][j] + Helper(grid, i+1, j, memo), grid[i][j] + Helper(grid, i, j+1, memo));
    }
    
    public int MinPathSum(int[][] grid) 
    {
        int[][] memo = new int[grid.Length][];
        for(int index = 0; index < memo.Length; index++)
        {
            memo[index] = new int[grid[0].Length];
            Array.Fill(memo[index], -1);
        }
        
        return Helper(grid, 0, 0, memo);
    }
}