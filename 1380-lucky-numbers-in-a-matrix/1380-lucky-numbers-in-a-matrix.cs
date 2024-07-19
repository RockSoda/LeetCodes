public class Solution 
{
    public IList<int> LuckyNumbers (int[][] matrix) 
    {
        bool IsMaxInCol(int col, int curr)
        {
            for(int i = 0; i < matrix.Length; i++)
            {
                if(matrix[i][col] > curr) return false;
            }
            
            return true;
        }
        
        var list = new List<int>();
        
        for(int i = 0; i < matrix.Length; i++)
        {
            int min = int.MaxValue;
            int minIdx = -1;
            for(int j = 0; j < matrix[i].Length; j++)
            {
                if(matrix[i][j] >= min) continue;
                
                min = matrix[i][j];
                minIdx = j;
            }
            
            if(IsMaxInCol(minIdx, min)) list.Add(min);
        }
        
        return list;
    }
}