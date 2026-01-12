public class Solution 
{
    public int MinTimeToVisitAllPoints(int[][] points) 
    {
        var moves = 0;
        for(int i = 1; i < points.Length; i++)
        {
            var fromPointA = points[i-1];
            var toPointB = points[i];
            moves += Math.Max(Math.Abs(fromPointA[0] - toPointB[0]), Math.Abs(fromPointA[1] - toPointB[1]));
        }
        return moves;
    }
}