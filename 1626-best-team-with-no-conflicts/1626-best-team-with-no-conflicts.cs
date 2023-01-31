public class Solution 
{
    private int Recurse(List<(int score, int age)> list, int index, int prevScore, Dictionary<(int, int), int> memo)
    {
        if(index >= list.Count) return 0;
        
        if(memo.ContainsKey((index, prevScore))) return memo[(index, prevScore)];
        
        if(prevScore > list[index].score) 
            return memo[(index, prevScore)] = Recurse(list, index+1, prevScore, memo);
        
        return memo[(index, prevScore)] = Math.Max(Recurse(list, index+1, list[index].score, memo) + list[index].score, Recurse(list, index+1, prevScore, memo));
    }
    
    public int BestTeamScore(int[] scores, int[] ages) 
    {
        var list = new List<(int score, int age)>();
        for(int i = 0; i < ages.Length; i++) list.Add((scores[i], ages[i]));
        list = list.OrderBy(x => x.age).ThenBy(x => x.score).ToList();
        
        var memo = new Dictionary<(int, int), int>();
        
        return Recurse(list, 0, -1, memo);
    }
}