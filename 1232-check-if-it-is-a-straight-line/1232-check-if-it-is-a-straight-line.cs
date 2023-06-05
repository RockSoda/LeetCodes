public class Solution 
{
    public bool CheckStraightLine(int[][] coordinates) 
    {
        double prev = 0;
        for(int i = 1; i < coordinates.Length; i++)
        {
            double x1 = coordinates[i-1][0];
            double x2 = coordinates[i][0];
            double y1 = coordinates[i-1][1];
            double y2 = coordinates[i][1];
            
            double slope = (y2-y1)/(x2-x1);
            if(x2-x1 == 0) slope = Math.Abs(slope);
            
            if(i == 1) prev = slope;
            else if(prev != slope) return false;
        }
        
        return true;
    }
}