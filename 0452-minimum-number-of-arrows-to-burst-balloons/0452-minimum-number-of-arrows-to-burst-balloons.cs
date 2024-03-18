public class Solution 
{
    public int FindMinArrowShots(int[][] points) 
    {
        points = points.OrderBy(point => point[1]).ToArray();
        int arrows = 1, end = points[0][1];
        
        for(int i = 1; i < points.Length; i++)
        {
            if(points[i][0] <= end) continue;
                
            arrows++;
            end = points[i][1];
        }
        
        return arrows;
        
    }
}