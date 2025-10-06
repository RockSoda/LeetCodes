public class Solution 
{
    private bool DFS(int[][] grid, int i, int j, int limit, HashSet<(int, int)> visited)
    {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] > limit || visited.Contains((i, j)))
            return false;
        
        visited.Add((i, j));

        if(i == grid.Length-1 && j == grid[i].Length-1) return true;

        return DFS(grid, i+1, j, limit, visited) ||
               DFS(grid, i, j+1, limit, visited) ||
               DFS(grid, i-1, j, limit, visited) ||
               DFS(grid, i, j-1, limit, visited);
    }

    public int SwimInWater(int[][] grid) 
    {
        var high = grid.Select(row => row.Max()).Max();
        var low = grid[0][0];
        var result = high;
        while(low <= high)
        {
            var mid = low + (high - low) / 2;
            
            if(DFS(grid, 0, 0, mid, new HashSet<(int, int)>())) 
            {
                result = mid;
                high = mid - 1;
            }
            else low = mid + 1;
        }
        return result;
    }
}