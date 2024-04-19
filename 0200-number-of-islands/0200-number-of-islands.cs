public class Solution 
{
    private void Traverse(char[][] grid, int i, int j)
    {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] != '1') return;
        
        grid[i][j] = '-';
        
        Traverse(grid, i+1, j);
        Traverse(grid, i-1, j);
        Traverse(grid, i, j+1);
        Traverse(grid, i, j-1);
    }
    
    public int NumIslands(char[][] grid) 
    {
        int counter = 0;
        
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] != '1') continue;
                    
                Traverse(grid, i, j);
                counter++;
            }
        }
        
        return counter;
    }
}