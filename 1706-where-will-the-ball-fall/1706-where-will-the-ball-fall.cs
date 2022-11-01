public class Solution 
{
    private int Fall(int[][] grid, int ball)
    {
        foreach(var row in grid)
        {
            int cell = row[ball];
            if(cell == 1 && (ball == row.Length - 1 || row[ball+1] == -1)) return -1;
            if(cell == -1 && (ball == 0 || row[ball-1] == 1)) return -1;
            
            ball += cell;
        }
        
        return ball;
    }
    
    public int[] FindBall(int[][] grid) 
    {
        var ans = new int[grid[0].Length];
        for(int i = 0; i < grid[0].Length; i++)
            ans[i] = Fall(grid, i);
        
        return ans;
    }
}