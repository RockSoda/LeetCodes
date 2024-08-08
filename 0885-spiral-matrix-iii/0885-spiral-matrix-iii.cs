public class Solution 
{
    private void MoveRight(List<int[]> l, int rows, int cols, ref int currR, ref int currC, int layer)
    {
        int colRef = currC;
        for(; currC <= colRef+(2*layer+1); currC++)
        {
            if(currR < 0 || currR >= rows || currC < 0 || currC >= cols) continue;
            
            l.Add(new int[]{currR, currC});
        }
        currC--;
    }
    
    private void MoveLeft(List<int[]> l, int rows, int cols, ref int currR, ref int currC, int layer)
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
    
    private void MoveUp(List<int[]> l, int rows, int cols, ref int currR, ref int currC, int layer)
    {
        int rowRef = currR;
        currR--;
        for(; currR > rowRef-(2*(layer+1)); currR--) 
        {
            if(currR < 0 || currR >= rows || currC < 0 || currC >= cols) continue;
                
            l.Add(new int[]{currR, currC});
        }
    }
    
    private void MoveDown(List<int[]> l, int rows, int cols, ref int currR, ref int currC, int layer)
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
        
        int layer = 0, currR = rStart, currC = cStart, size = rows*cols;
        
        while(true)
        {
            
            MoveRight(list, rows, cols, ref currR, ref currC, layer);
            if(list.Count == size) break;
            
            MoveDown(list, rows, cols, ref currR, ref currC, layer);
            if(list.Count == size) break;
            
            MoveLeft(list, rows, cols, ref currR, ref currC, layer);
            if(list.Count == size) break;
            
            MoveUp(list, rows, cols, ref currR, ref currC, layer);
            if(list.Count == size) break;
            
            layer++;
        }
        
        return list.ToArray();
    }
}