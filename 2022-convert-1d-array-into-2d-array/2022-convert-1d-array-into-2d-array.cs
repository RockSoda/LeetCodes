public class Solution 
{
    public int[][] Construct2DArray(int[] original, int m, int n) 
    {
        if(m*n != original.Length) return Array.Empty<int[]>();
        
        var mat = new int[m][];
        int index = 0;
        for(int i = 0; i < m; i++)
        {
            mat[i] = new int[n];
            for(int j = 0; j < n; j++) mat[i][j] = original[index++];
        }
        
        return mat;
    }
}