public class Solution
{
    private void DFS(int[][] grid, int i, int j, int dist = 1)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || (grid[i][j] != 0 && grid[i][j] <= dist)) return;
        
        grid[i][j] = dist;

        DFS(grid, i+1, j, dist+1);
        DFS(grid, i, j+1, dist+1);
        DFS(grid, i-1, j, dist+1);
        DFS(grid, i, j-1, dist+1);
    }

    public int MaxDistance(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    grid[i][j] = 0;
                    DFS(grid, i, j);
                }
            }
        }

        var max = -1;
        foreach (var row in grid)
        {
            var r = row.Where(c => c > 1);
            if (r.Any()) max = Math.Max(r.Max()-1, max);
        }

        return max;
    }
}