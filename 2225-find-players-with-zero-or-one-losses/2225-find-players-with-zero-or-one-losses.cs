public class Solution 
{
    public IList<IList<int>> FindWinners(int[][] matches) 
    {
        var winners = matches.Select(m => m[0]).ToHashSet();
        var winnerWhoLost = matches.Select(m => m[1]).Where(x => winners.Contains(x)).ToHashSet();
        var zeroLose = winners.Where(x => !winnerWhoLost.Contains(x)).ToList();
        zeroLose.Sort();
        
        var map = new Dictionary<int, int>();
        foreach(var match in matches)
            map[match[1]] = map.ContainsKey(match[1]) ? map[match[1]]+1 : 1;
        
        var lostOnce = map.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).ToList();
        lostOnce.Sort();
        
        return new List<IList<int>>{zeroLose, lostOnce};
    }
}