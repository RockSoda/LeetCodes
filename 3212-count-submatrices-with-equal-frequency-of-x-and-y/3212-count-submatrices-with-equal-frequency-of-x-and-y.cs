public class Solution 
{
    public int NumberOfSubmatrices(char[][] grid) 
    {
        (int x, int y)[][] prefixSum = new (int, int)[grid.Length][];
        for(int i = 0; i < grid.Length; i++) prefixSum[i] = new (int, int)[grid[i].Length];

        (int, int) GetXY(char c)
        {
            if(c == 'X') return (1, 0);
            else if(c == 'Y') return (0, 1);
            else return (0, 0);
        }

        prefixSum[0][0] = GetXY(grid[0][0]);
        
        for(int i = 1; i < grid.Length; i++)
        {
            (int x, int y) = GetXY(grid[i][0]);
            prefixSum[i][0] = (prefixSum[i-1][0].x + x, prefixSum[i-1][0].y + y);
            
        }
        
        for(int j = 1; j < grid[0].Length; j++)
        {
            (int x, int y) = GetXY(grid[0][j]);
            prefixSum[0][j] = (prefixSum[0][j-1].x + x, prefixSum[0][j-1].y + y);
        }


        for(int i = 1; i < grid.Length; i++)
        {
            for(int j = 1; j < grid[i].Length; j++)
            {
                (int x, int y) = GetXY(grid[i][j]);

                prefixSum[i][j] = (x + prefixSum[i][j-1].x + prefixSum[i-1][j].x - prefixSum[i-1][j-1].x, 
                                   y + prefixSum[i][j-1].y + prefixSum[i-1][j].y - prefixSum[i-1][j-1].y);
            }
        }
        
        return prefixSum.Select(row => row.Count(cell => cell.x == cell.y && cell.x != 0)).Sum();
    }
}