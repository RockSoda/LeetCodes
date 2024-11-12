public class Solution 
{
    public int[] MaximumBeauty(int[][] items, int[] queries) 
    {
        var max = new Stack<(int price, int beauty)>();
        foreach (var item in items.OrderBy(x => x[1])) 
        {
            while (max.Count > 0 && max.Peek().price >= item[1] && max.Peek().beauty < item[1]) max.Pop();
            max.Push((item[0], item[1]));
        }

        var map = new Dictionary<int, int>();
        foreach (var q in queries.OrderByDescending(x => x))
        {
            while (max.Count > 0 && max.Peek().price > q) max.Pop();
            map[q] = max.Count > 0 ? max.Peek().beauty : 0;
        }

        return queries.Select(q => map[q]).ToArray();
    }
}