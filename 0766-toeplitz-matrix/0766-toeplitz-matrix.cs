public class Solution 
{
    public bool IsToeplitzMatrix(int[][] matrix) 
    {
        for(int i = matrix.Length - 1; i >= 0; i--)
        {
            bool flag = false;
            int j = 0;
            int prev = matrix[i][j];
            int r = i;
            while(r < matrix.Length && j < matrix[r].Length)
            {
                if(matrix[r][j] != prev)
                {
                    flag = true;
                    break;
                }
                prev = matrix[r++][j++];
            }
            
            if(flag) return false;
        }
        
        for(int j = 1; j < matrix[0].Length; j++)
        {
            int i = 0;
            int prev = matrix[i][j];
            bool flag = false;
            int c = j;
            while(i < matrix.Length && c < matrix[i].Length)
            {
                if(matrix[i][c] != prev)
                {
                    flag = true;
                    break;
                }
                prev = matrix[i++][c++];
            }
            
            if(flag) return false;
        }
        
        return true;
    }
}