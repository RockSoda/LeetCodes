public class Solution 
{
    private void moveRight(List<int[]> l, int rows, int cols, ref int currR, ref int currC, int layer)
    {
        int colRef = currC;
        for(; currC <= colRef+(2*layer+1); currC++)
        {
            if(currR < 0 || currR >= rows || currC < 0 || currC >= cols) continue;
            
            l.Add(new int[]{currR, currC});
        }
        currC--;
    }
    
    private void moveLeft(List<int[]> l, int rows, int cols, ref int currR, ref int currC, int layer)
    {
        int colRef = currC;
        currC--;
        for(; currC >= colRef-(2*(layer+1)); currC--)
        {
            if(currR < 0 || currR >= rows || currC < 0 || currC >= cols) continue;
                
            l.Add(new int[]{currR, currC});
        }
        currC++;
    }
    
    private void moveUp(List<int[]> l, int rows, int cols, ref int currR, ref int currC, int layer)
    {
        int rowRef = currR;
        currR--;
        for(; currR > rowRef-(2*(layer+1)); currR--) 
        {
            if(currR < 0 || currR >= rows || currC < 0 || currC >= cols) continue;
                
            l.Add(new int[]{currR, currC});
        }
    }
    
    private void moveDown(List<int[]> l, int rows, int cols, ref int currR, ref int currC, int layer)
    {
        int rowRef = currR;
        currR++;
        for(; currR <= rowRef+(2*layer+1); currR++) 
        {
            if(currR < 0 || currR >= rows || currC < 0 || currC >= cols) continue;
                
            l.Add(new int[]{currR, currC});
        }
        currR--;
    }
    
    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart) 
    {
        var list = new List<int[]>();
        
        int layer = 0;
        
        int currR = rStart;
        int currC = cStart;
        
        while(true)
        {
            
            moveRight(list, rows, cols, ref currR, ref currC, layer);
            if(list.Count == rows*cols) break;
            
            moveDown(list, rows, cols, ref currR, ref currC, layer);
            if(list.Count == rows*cols) break;
            
            moveLeft(list, rows, cols, ref currR, ref currC, layer);
            if(list.Count == rows*cols) break;
            
            moveUp(list, rows, cols, ref currR, ref currC, layer);
            if(list.Count == rows*cols) break;
            
            layer++;
        }
        
        return list.ToArray();
    }
}