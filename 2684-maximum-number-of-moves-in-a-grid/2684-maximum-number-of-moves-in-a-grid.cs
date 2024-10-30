public class Solution 
{
    private int[][] CopyGrid(int[][] mat)
    {
        var output = new int[mat.Length][];
        for(int i = 0; i < output.Length; i++)
            output[i] = mat[i].ToArray();
        return output;
    }

    private int GetMax(int a, int b, int c) => Math.Max(a, Math.Max(b, c));

    private int Traverse(int[][] mat, int i, int j, int prev)
    {
        if(i < 0 || i >= mat.Length || j < 0 || j >= mat[i].Length || prev >= mat[i][j]) return -1;
        
        int curr = mat[i][j];
        mat[i][j] = 1000001;

        return GetMax(Traverse(CopyGrid(mat), i-1, j+1, curr) + 1,
                      Traverse(CopyGrid(mat), i, j+1, curr) + 1,
                      Traverse(CopyGrid(mat), i+1, j+1, curr) + 1);
    }

    public int MaxMoves(int[][] grid) 
    {
        int output = 0;
        
        for(int i = 0; i < grid.Length; i++)
            output = Math.Max(Traverse(CopyGrid(grid), i, 0, 0), output);

        return output;
    }
}