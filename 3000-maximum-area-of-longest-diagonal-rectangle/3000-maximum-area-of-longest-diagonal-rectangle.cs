public class Solution 
{
    public int AreaOfMaxDiagonal(int[][] dimensions) 
    {
        int maxDiagonal = 0, areaOfTheMax = 0;
        foreach(var dimension in dimensions)
        {
            var currDiagonal = dimension[0] * dimension[0] + dimension[1] * dimension[1];
            if(currDiagonal < maxDiagonal) continue;

            areaOfTheMax = currDiagonal == maxDiagonal ? 
                           Math.Max(dimension[0] * dimension[1], areaOfTheMax) : 
                           dimension[0] * dimension[1];
            
            maxDiagonal = currDiagonal;
        }
        return areaOfTheMax;
    }
}