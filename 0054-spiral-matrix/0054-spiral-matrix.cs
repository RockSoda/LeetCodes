public class Solution 
{
    private void moveRight(List<int> l, int[][] m, int start, int end, int layer)
    {
        for(int i = start; i <= end; i++) l.Add(m[layer][i]);
    }
    
    private void moveLeft(List<int> l, int[][] m, int start, int end, int layer)
    {
        for(int i = start; i >= end; i--) l.Add(m[m.Length-layer-1][i]);
    }
    
    private void moveUp(List<int> l, int[][] m, int start, int end, int layer)
    {
        for(int i = start; i >= end; i--) l.Add(m[i][layer]);
    }
    
    private void moveDown(List<int> l, int[][] m, int start, int end, int layer)
    {
        for(int i = start; i <= end; i++) l.Add(m[i][m[0].Length-layer-1]);
    }
    
    public IList<int> SpiralOrder(int[][] matrix) 
    {
        List<int> output = new List<int>();
        
        int layer = 0;
        
        int x = matrix[0].Length-1;
        int y = matrix.Length-1;
        
        while(true)
        {
            
            moveRight(output, matrix, layer, x-layer, layer);
            if(output.Count == (x+1)*(y+1)) break;
            
            moveDown(output, matrix, layer+1, y-layer, layer);
            if(output.Count == (x+1)*(y+1)) break;
            
            moveLeft(output, matrix, x-layer-1, layer, layer);
            if(output.Count == (x+1)*(y+1)) break;
            
            moveUp(output, matrix, y-layer-1, layer+1, layer);
            if(output.Count == (x+1)*(y+1)) break;
            
            layer = layer+1;
        }
        
        return output;
    }
}