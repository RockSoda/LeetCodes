public class Solution 
{
    public int[][] Transpose(int[][] matrix) 
    {
        var output = new int[matrix[0].Length][];
        for(int i = 0; i < output.Length; i++) output[i] = new int[matrix.Length];
        
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[i].Length; j++) output[j][i] = matrix[i][j];
        }
        
        return output;
    }
}