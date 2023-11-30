public class Solution 
{
    private int GetSubStrIdx(int idx, string num)
    {
        for (int i = idx; i < num.Length; i++)
            if (num[i] != '0') return i;

        return -1;
    }
    
    private int Recurse(string num, int idx)
    {
        int newIdx = GetSubStrIdx(idx, num);

        if (newIdx == -1) return 0;

        if (num.Substring(newIdx) == "1") return 1;

        return (int)Math.Pow(2, num.Length - newIdx) - 1 - Recurse(num, newIdx + 1);
    }
    
    public int MinimumOneBitOperations(int n) 
    {
        var bits = Convert.ToString(n, 2);
        return Recurse(bits, 0);
    }
}