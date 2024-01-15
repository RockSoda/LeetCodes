public class Solution 
{
    public IList<IList<int>> FindWinners(int[][] matches) 
    {
        var map = new Dictionary<int, int>();
        foreach(var match in matches)
        {
            if (!map.ContainsKey(match[0])) map[match[0]] = 0;
            map[match[1]] = map.ContainsKey(match[1]) ? map[match[1]]+1 : 1;
        }
        
        var lostOnce = map.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).ToList();
        lostOnce.Sort();
        var zeroLose = map.Where(kvp => kvp.Value == 0).Select(kvp => kvp.Key).ToList();
        zeroLose.Sort();
        
        return new List<IList<int>>{zeroLose, lostOnce};
    }
}