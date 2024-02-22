public class Solution 
{
    public int FindJudge(int n, int[][] trust) 
    {
        if(trust.Length == 0) return n == 1 ? 1 : -1;
        
        var trusted = trust.Select(r => r[1]).ToList();
        
        var map = new Dictionary<int, int>();
        foreach(var t in trusted) map[t] = map.ContainsKey(t) ? map[t] + 1 : 1;
        
        var potentialJudges = map.Where(kvp => kvp.Value == n-1).Select(kvp => kvp.Key).ToList();
        
        var trustee = trust.Select(r => r[0]).ToHashSet();
        
        var judge = potentialJudges.Find(j => !trustee.Contains(j));
        return judge == 0 ? -1 : judge;
    }
}