public class Solution 
{
    public int[] FindDiagonalOrder(IList<IList<int>> nums) 
    {
        var tuples = new List<(int sum, int row, int val)>();
        for(int i = 0; i < nums.Count; i++)
        {
            for(int j = 0; j < nums[i].Count; j++)
                tuples.Add((i+j, i, nums[i][j]));
        }
        
        return tuples.OrderBy(tuple => tuple.sum).ThenByDescending(tuple => tuple.row).Select(tuple => tuple.val).ToArray();
    }
}