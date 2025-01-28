public class Solution 
{
    public int FindMaxFish(int[][] grid) 
    {
        int currFish = 0, maxFish = 0;

        var visited = new HashSet<(int, int)>();
        void Traverse(int i, int j)
        {
            if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == 0 || visited.Contains((i, j)))
                return;

            currFish += grid[i][j];
            visited.Add((i, j));

            Traverse(i+1, j);
            Traverse(i-1, j);
            Traverse(i, j+1);
            Traverse(i, j-1);
        }

        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == 0 || visited.Contains((i, j))) continue;
                
                currFish = 0;
                Traverse(i, j);
                maxFish = Math.Max(currFish, maxFish);
            }
        }
        return maxFish;
    }
}