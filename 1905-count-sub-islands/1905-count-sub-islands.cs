public class Solution 
{
    private void PaintIsland(int[][] grid, int i, int j, HashSet<(int, int)> hset)
    {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] != 1) return;
        
        grid[i][j] = 2;
        hset.Add((i, j));
        
        PaintIsland(grid, i+1, j, hset);
        PaintIsland(grid, i, j+1, hset);
        PaintIsland(grid, i-1, j, hset);
        PaintIsland(grid, i, j-1, hset);
    }
    
    private void PaintIslandWithKeys(int[][] grid, int i, int j, HashSet<(int, int)> hset, int starti, int startj, Dictionary<(int, int), (int, int)> map)
    {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] != 1) return;
        
        grid[i][j] = 2;
        hset.Add((i, j));
        map[(i, j)] = (starti, startj);
        
        PaintIslandWithKeys(grid, i+1, j, hset, starti, startj, map);
        PaintIslandWithKeys(grid, i, j+1, hset, starti, startj, map);
        PaintIslandWithKeys(grid, i-1, j, hset, starti, startj, map);
        PaintIslandWithKeys(grid, i, j-1, hset, starti, startj, map);
    }
    
    public int CountSubIslands(int[][] grid1, int[][] grid2) 
    {
        int counter = 0;
        
        var valToKey = new Dictionary<(int, int), (int, int)>();
        var keyToIslands = new Dictionary<(int, int), HashSet<(int, int)>>();
        
        for(int i = 0; i < grid2.Length; i++)
        {
            for(int j = 0; j < grid2[i].Length; j++)
            {
                if(grid1[i][j] == 0 || grid2[i][j] != 1) continue;
                
                var hset1 = new HashSet<(int, int)>();
                if(grid1[i][j] == 2) 
                {
                    hset1 = keyToIslands[valToKey[(i, j)]];
                }
                else
                {
                    PaintIslandWithKeys(grid1, i, j, hset1, i, j, valToKey);
                    keyToIslands.Add((i, j), hset1);
                }
                
                var hset2 = new HashSet<(int, int)>();
                PaintIsland(grid2, i, j, hset2);
                
                if(hset2.IsSubsetOf(hset1)) counter++;
            }
        }
        
        return counter;
    }
}