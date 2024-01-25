public class Solution 
{
    private int Recurse(string text1, string text2, int idx1, int idx2, int[][] memo)
    {
        if(idx1 >= text1.Length || idx2 >= text2.Length) return 0;
        
        if(memo[idx1][idx2] != -1) return memo[idx1][idx2];
        
        if(text1[idx1] == text2[idx2]) return memo[idx1][idx2] = Recurse(text1, text2, idx1+1, idx2+1, memo)+1;
        
        else return memo[idx1][idx2] = Math.Max(Recurse(text1, text2, idx1+1, idx2, memo), Recurse(text1, text2, idx1, idx2+1, memo));
    }
    
    public int LongestCommonSubsequence(string text1, string text2) 
    {
        var memo = new int[text1.Length][];
        for(int i = 0; i < memo.Length; i++)
        {
            memo[i] = new int[text2.Length];
            Array.Fill(memo[i], -1);
        }
        
        return Recurse(text1, text2, 0, 0, memo);
    }
}