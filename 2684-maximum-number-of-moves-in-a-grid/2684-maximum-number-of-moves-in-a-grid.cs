public class Solution 
{
    private int GetMax(int a, int b, int c) => Math.Max(a, Math.Max(b, c));

    private int Traverse(int[][] mat, int i, int j, int prev, int[][] memo)
    {
        if(i < 0 || i >= mat.Length || j < 0 || j >= mat[i].Length || prev >= mat[i][j]) return -1;
        if(memo[i][j] != -1) return memo[i][j];

        int curr = mat[i][j];
        mat[i][j] = 1000001;

        memo[i][j] = GetMax(Traverse(mat, i-1, j+1, curr, memo) + 1,
                         Traverse(mat, i, j+1, curr, memo) + 1,
                         Traverse(mat, i+1, j+1, curr, memo) + 1);
        mat[i][j] = curr;
        return memo[i][j];
    }

    public int MaxMoves(int[][] grid) 
    {
        int output = 0;
        var memo = new int[grid.Length][];
        for(int i = 0; i < memo.Length; i++)
        {
            memo[i] = new int[grid[i].Length];
            Array.Fill(memo[i], -1);
        }

        for(int i = 0; i < grid.Length; i++)
            output = Math.Max(Traverse(grid, i, 0, 0, memo), output);

        return output;
    }
}