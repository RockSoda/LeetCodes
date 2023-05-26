public class Solution 
{
    private int Recurse(int[] piles, int M, int index, bool isAlice, Dictionary<(int, int, bool), int> memo)
    {
        if(index >= piles.Length) return 0;
        
        if(memo.ContainsKey((index, M, isAlice))) return memo[(index, M, isAlice)];
        
        int ans = isAlice ? 0 : int.MaxValue;
        int currStones = 0;
        for(int X = 1; X <= 2*M; X++)
        {
            int currIndex = index + X - 1;
            if(currIndex >= piles.Length) break;
            
            currStones += piles[currIndex];
            
            if(isAlice)
            {
                int nextStones = Recurse(piles, Math.Max(M, X), index + X, false, memo);
                int totalStones = currStones + nextStones;
                ans = Math.Max(totalStones, ans);
            }
            else
            {
                int nextStones = Recurse(piles, Math.Max(M, X), index + X, true, memo);
                ans = Math.Min(nextStones, ans);
            }
        }
        
        return memo[(index, M, isAlice)] = ans;
    }
    
    public int StoneGameII(int[] piles) 
    {
        var memo = new Dictionary<(int, int, bool), int>();
        return Recurse(piles, 1, 0, true, memo);
    }
}