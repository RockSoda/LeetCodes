public class Solution 
{
    public bool IsToeplitzMatrix(int[][] matrix) 
    {
        for(int i = matrix.Length - 1; i >= 0; i--)
        {
            int j = 0;
            int prev = matrix[i][j];
            int r = i;
            while(r < matrix.Length && j < matrix[r].Length)
            {
                if(matrix[r][j] != prev) return false;
                prev = matrix[r++][j++];
            }
        }
        
        for(int j = 1; j < matrix[0].Length; j++)
        {
            int i = 0;
            int prev = matrix[i][j];
            int c = j;
            while(i < matrix.Length && c < matrix[i].Length)
            {
                if(matrix[i][c] != prev) return false;
                prev = matrix[i++][c++];
            }
        }
        
        return true;
    }
}