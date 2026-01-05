public class Solution 
{
    public long MaxMatrixSum(int[][] matrix) 
    {
        var absMin = (int)(Math.Pow(10, 5) + 1);
        bool isOddNeg = false;
        long absSum = 0;
        foreach(var row in matrix)
        {
            foreach(var cell in row)
            {
                var absCell = Math.Abs(cell);
                absSum += absCell;
                absMin = Math.Min(absMin, absCell);
                if(cell < 0) isOddNeg = !isOddNeg;
            }
        }

        return isOddNeg ? absSum - 2 * absMin : absSum;
    }
}