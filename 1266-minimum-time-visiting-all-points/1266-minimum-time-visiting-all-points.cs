public class Solution 
{
    private int Move(int fromPointAx, int fromPointAy, int toPointBx, int toPointBy)
    {
        int moves = 0;
        while(fromPointAx > toPointBx && fromPointAy > toPointBy)
        {
            fromPointAx--;
            fromPointAy--;
            moves++;
        }

        while(fromPointAx < toPointBx && fromPointAy < toPointBy)
        {
            fromPointAx++;
            fromPointAy++;
            moves++;
        }

        while(fromPointAx > toPointBx && fromPointAy < toPointBy)
        {
            fromPointAx--;
            fromPointAy++;
            moves++;
        }

        while(fromPointAx < toPointBx && fromPointAy > toPointBy)
        {
            fromPointAx++;
            fromPointAy--;
            moves++;
        }

        while(fromPointAx < toPointBx)
        {
            fromPointAx++;
            moves++;
        }

        while(fromPointAx > toPointBx)
        {
            fromPointAx--;
            moves++;
        }

        while(fromPointAy > toPointBy)
        {
            fromPointAy--;
            moves++;
        }

        while(fromPointAy < toPointBy)
        {
            fromPointAy++;
            moves++;
        }

        return moves;
    }

    public int MinTimeToVisitAllPoints(int[][] points) 
    {
        var moves = 0;
        for(int i = 1; i < points.Length; i++)
        {
            var fromPointA = points[i-1];
            var toPointB = points[i];
            moves += Move(fromPointA[0], fromPointA[1], toPointB[0], toPointB[1]);
        }
        return moves;
    }
}