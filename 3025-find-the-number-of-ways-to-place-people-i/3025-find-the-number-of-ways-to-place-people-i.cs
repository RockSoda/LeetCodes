public class Solution 
{
    public int NumberOfPairs(int[][] points) 
    {
        bool IsLegalUpperLeft(int[] upperLeft, int[] lowerRight) 
        {
            if(upperLeft[0] > lowerRight[0] || upperLeft[1] < lowerRight[1]) return false;
            
            if(points.Any(point => (point[0] != upperLeft[0] || point[1] != upperLeft[1]) && 
                                    (point[0] != lowerRight[0] || point[1] != lowerRight[1]) && 
                                    ContainsTarget(upperLeft, lowerRight, point))) return false;
            
            return true;
        }

        bool ContainsTarget(int[] upperLeft, int[] lowerRight, int[] target) => upperLeft[0] <= target[0] && 
                                                                                lowerRight[0] >= target[0] && 
                                                                                upperLeft[1] >= target[1] && 
                                                                                lowerRight[1] <= target[1];
        
        var numOfPairs = 0;
        for(int i = 0; i < points.Length; i++)
        {
            for(int j = i+1; j < points.Length; j++)
            {
                if(IsLegalUpperLeft(points[i], points[j]) || IsLegalUpperLeft(points[j], points[i])) numOfPairs++;
            }
        }
        return numOfPairs;
    }
}