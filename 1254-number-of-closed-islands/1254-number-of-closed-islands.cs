public class Solution 
{
    private bool BFS(int[][] grid, int i, int j)
    {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length) return false;
        
        if(grid[i][j] == 1) return true;
        
        grid[i][j] = 1;
        
        bool down = BFS(grid, i+1, j);
        bool up = BFS(grid, i-1, j);
        bool right = BFS(grid, i, j+1);
        bool left = BFS(grid, i, j-1);
        
        return down && up && right && left;
    }
    
    public int ClosedIsland(int[][] grid) 
    {
        int counter = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
                if(grid[i][j] == 0 && BFS(grid, i, j)) counter++;
        }
        
        return counter;
    }
}