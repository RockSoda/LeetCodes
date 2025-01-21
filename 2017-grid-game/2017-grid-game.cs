public class Solution 
{
    public long GridGame(int[][] grid) 
    {
        long rowSum = grid[0].Sum();
        long min = long.MaxValue;
        long secondRowSum = 0;

        for(int i = 0; i < grid[0].Length; i++)
        {
            rowSum -= grid[0][i];
            min = Math.Min(min, Math.Max(rowSum, secondRowSum));
            secondRowSum += grid[1][i];
        }

        return min;
    }
}