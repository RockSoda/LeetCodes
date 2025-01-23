public class Solution 
{
    private int _communicatedServers;

    private void FlipCommunicated(int[][] grid, int i, int j)
    {   
        bool isCommunicating = false;
        for(int row = 0; row < grid.Length; row++)
        {
            if(row == i || grid[row][j] == 0) continue;

            if(grid[row][j] != -1) _communicatedServers++;
            grid[row][j] = -1;
            isCommunicating = true;
        }

        for(int col = 0; col < grid[i].Length; col++)
        {
            if(col == j || grid[i][col] == 0) continue;

            if(grid[i][col] != -1) _communicatedServers++;
            grid[i][col] = -1;
            isCommunicating = true;
        }

        if (!isCommunicating) return;

        grid[i][j] = -1;
        _communicatedServers++;
    }

    public int CountServers(int[][] grid) 
    {
        _communicatedServers = 0;
        
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] != 1) continue;
                FlipCommunicated(grid, i, j);
            }
        }

        return _communicatedServers;
    }
}