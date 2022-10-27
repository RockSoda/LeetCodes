public class Solution 
{
    public int MaxPoints(int[][] points) 
    {
        if(points.Length == 1) return 1;
        
        var slopeMap = new Dictionary<(double, double), HashSet<(int, int)>>();
        var xMap = new Dictionary<int, HashSet<(int, int)>>();
        var yMap = new Dictionary<int, HashSet<(int, int)>>();
        
        for(int i = 0; i < points.Length; i++)
        {
            for(int j = i+1; j < points.Length; j++)
            {
                int numerator = points[j][1] - points[i][1];
                int denominator = points[j][0] - points[i][0];
                
                if(denominator == 0)
                {
                    int x = points[i][0];
                    if(xMap.ContainsKey(x)) xMap[x].Add((points[j][0], points[j][1]));
                    else xMap[x] = new HashSet<(int, int)>{ (points[i][0], points[i][1]), (points[j][0], points[j][1]) };
                }
                else if(numerator == 0)
                {
                    int y = points[i][1];
                    if(yMap.ContainsKey(y)) yMap[y].Add((points[j][0], points[j][1]));
                    else yMap[y] = new HashSet<(int, int)>{ (points[i][0], points[i][1]), (points[j][0], points[j][1]) };
                }
                else
                {
                    double slope = (double)(numerator) / (double)(denominator);
                    double yIntercept = Math.Round(points[j][1] - (double)(numerator) / (double)(denominator) * points[j][0], 6);
                    if(yIntercept.ToString().Contains('.'))
                        yIntercept = double.Parse(yIntercept.ToString().Substring(0, yIntercept.ToString().Length - 1));
                    
                    if(slopeMap.ContainsKey((slope, yIntercept))) 
                        slopeMap[(slope, yIntercept)].Add((points[j][0], points[j][1]));
                    else 
                        slopeMap[(slope, yIntercept)] = new HashSet<(int, int)>{ (points[i][0], points[i][1]), (points[j][0], points[j][1]) };
                }
            }
        }
        
        int maxSlope = slopeMap.Count > 0 ? slopeMap.Values.Select(x => x.Count).Max() : 0;
        int maxX = xMap.Count > 0 ? xMap.Values.Select(x => x.Count).Max() : 0;
        int maxY = yMap.Count > 0 ? yMap.Values.Select(x => x.Count).Max() : 0;
        
        return Math.Max(Math.Max(maxX, maxY), maxSlope);
    }
}