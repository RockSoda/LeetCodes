public class Solution 
{
    public int MinCostConnectPoints(int[][] points) 
    {
        int GetDist(int[] a, int[] b) => 
            Math.Abs(a[0] - b[0]) + Math.Abs(a[1] - b[1]);
        
        int current = 0;
        int result = 0;
        var data = new int[points.Length];
        Array.Fill(data, int.MaxValue);
        data[current] = -1;
        
        for (int j = 0; j < points.Length - 1; j++)
        {
            int minVal = int.MaxValue, nextIndex = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (data[i] == -1) continue;
                
                var distance = GetDist(points[i], points[current]);
                data[i] = Math.Min(data[i], distance);
                
                if (minVal <= data[i]) continue;
                
                minVal = data[i];
                nextIndex = i;
            }
            
            result += minVal;
            current = nextIndex;
            data[nextIndex] = -1;
        }
        
        return result;
    }
}