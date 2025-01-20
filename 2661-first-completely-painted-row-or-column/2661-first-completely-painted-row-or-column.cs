public class Solution 
{
    public int FirstCompleteIndex(int[] arr, int[][] mat) 
    {
        var matMap = new Dictionary<int, (int, int)>();

        var rowFreq = new int[mat.Length];
        Array.Fill(rowFreq, mat[0].Length);
        var colFreq = new int[mat[0].Length];
        Array.Fill(colFreq, mat.Length);

        for(int i = 0; i < mat.Length; i++)
        {
            for(int j = 0; j < mat[i].Length; j++) matMap[mat[i][j]] = (i, j);
        }

        for(int i = 0; i < arr.Length; i++)
        {
            var curr = arr[i];
            (int row, int col) = matMap[curr];
            
            if(--rowFreq[row] == 0) return i;
            if(--colFreq[col] == 0) return i;
        }

        return -1;
    }
}