public class Solution 
{
    public int NumberOfPairs(int[][] points) 
    {
        bool IsUpperLeft(int[] upperleft, int[] lowerright) => upperleft[0] <= lowerright[0] && 
                                                               upperleft[1] >= lowerright[1];

        bool ContainsTarget(int[] upperleft, int[] lowerright, int[] target) => upperleft[0] <= target[0] && 
                                                                                lowerright[0] >= target[0] && 
                                                                                upperleft[1] >= target[1] && 
                                                                                lowerright[1] <= target[1];
        
        var pairs = new List<(int[], int[])>();
        for(int i = 0; i < points.Length; i++)
        {
            for(int j = i+1; j < points.Length; j++)
            {
                if(IsUpperLeft(points[i], points[j])) pairs.Add((points[i], points[j]));
                else if(IsUpperLeft(points[j], points[i])) pairs.Add((points[j], points[i]));
            }
        }

        foreach((int[] upperLeft, int[] lowerRight) in pairs.ToList())
        {
            foreach(var point in points)
            {
                if(point[0] == upperLeft[0] && point[1] == upperLeft[1] || 
                   point[0] == lowerRight[0] && point[1] == lowerRight[1]) continue;

                if(ContainsTarget(upperLeft, lowerRight, point)) pairs.Remove((upperLeft, lowerRight));
            }
        }
        return pairs.Count;
    }
}