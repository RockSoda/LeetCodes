public class Solution 
{
    public int[][] ImageSmoother(int[][] img) 
    {
        //a b c
        //d e f
        //g h i
        int rowLength = img.Length;
        int colLength = img[0].Length;
        
        int GetFiltered(int row, int col)
        {
            int divisor = 9;
            (int a, int b, int c, int d, int e, int f, int g, int h, int i) = (0, 0, 0, 0, 0, 0, 0, 0, 0);
            
            bool cannotTop = row < 1, cannotLeft = col < 1, cannotBottom = row + 1 >= rowLength, cannotRight = col + 1 >= colLength;
            
            if (cannotTop || cannotLeft) divisor--;
            else a = img[row-1][col-1];
            
            if (cannotTop) divisor--;
            else b = img[row-1][col];
            
            if (cannotTop || cannotRight) divisor--;
            else c = img[row-1][col+1];
            
            if (cannotLeft) divisor--;
            else d = img[row][col-1];
            
            e = img[row][col];
            
            if (cannotRight) divisor--;
            else f = img[row][col+1];
            
            if (cannotBottom || cannotLeft) divisor--;
            else g = img[row+1][col-1];
            
            if (cannotBottom) divisor--;
            else h = img[row+1][col];
            
            if (cannotBottom || cannotRight) divisor--;
            else i = img[row+1][col+1];
            
            return (a+b+c+d+e+f+g+h+i) / divisor;
        }
        
        var smoothed = new int[rowLength][];
        for(int i = 0; i < rowLength; i++)
        {
            smoothed[i] = new int[colLength];
            for(int j = 0; j < colLength; j++)
            {
                smoothed[i][j] = GetFiltered(i, j);
            }
        }
        
        return smoothed;
    }
}