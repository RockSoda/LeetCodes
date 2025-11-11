public class Solution 
{
    private int GetNumOfOnes(string str) => str.Count(c => c == '1');

    private Dictionary<string, int> NumOfOnesMap;
    private Dictionary<(int, int, int), int> Memo;

    private int Recurse(string[] strs, int m, int n, int idx)
    {
        if (idx >= strs.Length) return 0;
        if (m == 0 && n == 0) return 0;
        if(Memo.ContainsKey((m, n, idx))) return Memo[(m, n, idx)];

        int numOfOnes = NumOfOnesMap[strs[idx]];
        int numOfZeros = strs[idx].Length - numOfOnes;

        var maxLen = 0;
        if (numOfOnes <= n && numOfZeros <= m)
        {
            maxLen = Recurse(strs, m-numOfZeros, n-numOfOnes, idx+1)+1;
        }

        return Memo[(m, n, idx)] = Math.Max(Recurse(strs, m, n, idx+1), maxLen);
    }

    public int FindMaxForm(string[] strs, int m, int n) 
    {
        NumOfOnesMap = new Dictionary<string, int>();
        Memo = new Dictionary<(int, int, int), int>();
        foreach(var str in strs) NumOfOnesMap[str] = GetNumOfOnes(str);

        return Recurse(strs, m, n, 0);
    }
}