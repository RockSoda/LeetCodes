public class Solution 
{
    private int Recurse(int[][] obstacleGrid, int i, int j, int[][] memo)
    {
        if(i < 0 || i >= obstacleGrid.Length || j < 0 || j >= obstacleGrid[i].Length || obstacleGrid[i][j] == 1) return 0;
        
        if(i == obstacleGrid.Length-1 && j == obstacleGrid[i].Length-1) return 1;
        
        if(memo[i][j] != -1) return memo[i][j];
        
        obstacleGrid[i][j] = 1;

        memo[i][j] = 0;
        
        memo[i][j] += Recurse(obstacleGrid, i+1, j, memo);
        memo[i][j] += Recurse(obstacleGrid, i, j+1, memo);
        
        obstacleGrid[i][j] = 0;
        
        return memo[i][j];
    }
    
    public int UniquePathsWithObstacles(int[][] obstacleGrid) 
    {
        int[][] memo = new int[obstacleGrid.Length][];
        for(int i = 0; i < memo.Length; i++)
        {
            memo[i] = new int[obstacleGrid[0].Length];
            Array.Fill(memo[i], -1);
        }
        return Recurse(obstacleGrid, 0, 0, memo);
    }
}