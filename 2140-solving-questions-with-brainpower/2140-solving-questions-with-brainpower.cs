public class Solution 
{
    private long Recurse(int[][] q, int index, Dictionary<int, long> memo)
    {
        if(index >= q.Length) return 0;
        
        if(memo.ContainsKey(index)) return memo[index];
        
        return memo[index] = Math.Max(Recurse(q, index+1, memo), q[index][0]+Recurse(q, index+1+q[index][1], memo));
    }
    
    public long MostPoints(int[][] questions) 
    {
        var memo = new Dictionary<int, long>();
        return Recurse(questions, 0, memo);
    }
}