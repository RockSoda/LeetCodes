public class Solution 
{
    public int MaxWidthOfVerticalArea(int[][] points) 
    {
        var xAry = points.Select(point => point[0]).ToArray();
        
        Array.Sort(xAry);
        
        var maxDist = 0;
        for(int i = 1; i < xAry.Length; i++)
            maxDist = Math.Max(maxDist, xAry[i] - xAry[i-1]);
        
        return maxDist;
    }
}