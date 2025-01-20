public class Solution 
{
    public int FirstCompleteIndex(int[] arr, int[][] mat) 
    {
        var matMap = new Dictionary<int, (int, int)>();
        var rowMap = new Dictionary<int, HashSet<int>>();
        var colMap = new Dictionary<int, HashSet<int>>();

        void AddToMap(Dictionary<int, HashSet<int>> map, int key, int val)
        {
            if(!map.ContainsKey(key)) map[key] = new HashSet<int>();
            map[key].Add(val);
        }

        for(int i = 0; i < mat.Length; i++)
        {
            for(int j = 0; j < mat[i].Length; j++)
            {
                var curr = mat[i][j];
                matMap[curr] = (i, j);
                AddToMap(rowMap, i, curr);
                AddToMap(colMap, j, curr);
            }
        }

        bool IsEmptyAfterRemovedFromMap(Dictionary<int, HashSet<int>> map, int key, int val)
        {
            map[key].Remove(val);
            return map[key].Count == 0;
        }

        for(int i = 0; i < arr.Length; i++)
        {
            var curr = arr[i];
            (int row, int col) = matMap[curr];
            if(IsEmptyAfterRemovedFromMap(rowMap, row, curr)) return i;
            if(IsEmptyAfterRemovedFromMap(colMap, col, curr)) return i;
        }

        return -1;
    }
}