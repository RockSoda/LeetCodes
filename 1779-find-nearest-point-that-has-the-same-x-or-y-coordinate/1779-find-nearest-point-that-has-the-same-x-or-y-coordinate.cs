public class Solution 
{
    public int NearestValidPoint(int x, int y, int[][] points) 
    {
        var valid = new Dictionary<int, int[]>();
        
        for(int i = 0; i < points.Length; i++)
        {
            var point = points[i];
            if(point[0] == x || point[1] == y) valid.Add(i, point);
        }
        
        int min = int.MaxValue;
        int index = -1;
        foreach(var kvp in valid)
        {
            var point = kvp.Value;
            var distance = Math.Abs(point[0]-x) + Math.Abs(point[1]-y);
            if(distance < min)
            {
                min = distance;
                index = kvp.Key;
            }
        }
        
        return index;
    }
}