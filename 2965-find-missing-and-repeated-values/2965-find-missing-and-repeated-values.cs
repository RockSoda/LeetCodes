public class Solution 
{
    public int[] FindMissingAndRepeatedValues(int[][] grid) 
    {
        var setOfNums = new HashSet<int>();
        var n = grid.Length;

        for(int i = 1; i <= n*n; i++) setOfNums.Add(i);

        var ans = new int[2];
        foreach(var row in grid)
        {
            foreach(var cell in row)
            {
                if(!setOfNums.Remove(cell)) ans[0] = cell;
            }
        }
        ans[1] = setOfNums.ToList().First();

        return ans;
    }
}