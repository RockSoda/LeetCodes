public class Solution 
{
    public int NumSpecial(int[][] mat) 
    {
        bool IsSpecialRow(int[] row, out int idx)
        {
            idx = -1;
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] != 1) continue;
                
                if (idx == -1) idx = i;
                else return false;
            }

            return idx != -1;
        }

        var output = 0;
        var map = new Dictionary<int, bool>();
        for(int i = 0; i < mat.Length; i++)
        {
            if(!IsSpecialRow(mat[i], out int idx)) continue;

            if(map.ContainsKey(idx))
            {
                output += map[idx] ? 1 : 0;
                continue;
            }
            
            if(mat.Count(row => row[idx] == 1) == 1)
            {
                output++;
                map[idx] = true;
            }
            else map[idx] = false;
        }

        return output;
    }
}