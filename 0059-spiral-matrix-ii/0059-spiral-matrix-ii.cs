public class Solution 
{
    private int num;
    
    private void MoveRight(int[][] m, int start, int end, int layer)
    {
        for(int i = start; i <= end; i++) m[layer][i] = num++;
    }
    
    private void MoveLeft(int[][] m, int start, int end, int layer)
    {
        for(int i = start; i >= end; i--) m[m.Length-layer-1][i] = num++;
    }
    
    private void MoveUp(int[][] m, int start, int end, int layer)
    {
        for(int i = start; i >= end; i--) m[i][layer] = num++;
    }
    
    private void MoveDown(int[][] m, int start, int end, int layer)
    {
        for(int i = start; i <= end; i++) m[i][m[0].Length-layer-1] = num++;
    }
    
    public int[][] GenerateMatrix(int n) 
    {
        var mat = new int[n][];
        for(int i = 0; i < n; i++) mat[i] = new int[n];
        
        int layer = 0;
        
        int x = n-1;
        int y = n-1;
        
        num = 1;
        
        while(true)
        {
            
            MoveRight(mat, layer, x-layer, layer);
            if(num > n*n) break;
            
            MoveDown(mat, layer+1, y-layer, layer);
            if(num > n*n) break;
            
            MoveLeft(mat, x-layer-1, layer, layer);
            if(num > n*n) break;
            
            MoveUp(mat, y-layer-1, layer+1, layer);
            if(num > n*n) break;
            
            layer++;
        }
        
        return mat;
    }
}