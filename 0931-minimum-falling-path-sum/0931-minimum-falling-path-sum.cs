public class Solution 
{
    public int MinFallingPathSum(int[][] matrix) 
    {
        int min = int.MaxValue;
        var visited = new int[matrix.Length][];
        for(int i = 0; i < visited.Length; i++)
        {
            visited[i] = new int[matrix[0].Length];
            Array.Fill(visited[i], int.MaxValue);
        }
        
        void LoadMin(int x, int y, int sum)
        {
            if(x >= matrix.Length || x < 0 || y >= matrix[x].Length || y < 0) return;
            
            int currSum = sum + matrix[x][y];
            
            if(visited[x][y] <= currSum) return;
            
            if(x == matrix.Length-1) min = Math.Min(min, currSum);
            
            LoadMin(x + 1, y - 1, currSum);
            LoadMin(x + 1, y , currSum);
            LoadMin(x + 1, y + 1, currSum);
            
            visited[x][y] = Math.Min(visited[x][y], currSum);
        }
        
        for(int j = 0; j < matrix[0].Length; j++)
            LoadMin(0, j, 0);
        
        return min;
    }
}