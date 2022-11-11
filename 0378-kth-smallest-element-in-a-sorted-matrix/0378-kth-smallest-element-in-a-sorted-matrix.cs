public class Solution 
{
    public int KthSmallest(int[][] matrix, int k) 
    {
        if (matrix == null) return 0;

        int row = matrix.Length;
        int col = matrix[0].Length;
        int low = matrix[0][0];
        int high = matrix[row - 1][col - 1];

        while (low < high)
        {
            int mid = low + (high - low) / 2;
            int count = 0;

            for (int i = 0; i < row; i++)
                count += matrix[i].Count(c => c <= mid);

            if (count < k) low = mid + 1;
            else high = mid;
        }

        return low;
    }
}