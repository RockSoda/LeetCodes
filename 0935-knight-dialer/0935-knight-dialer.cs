public class Solution 
{
    private Dictionary<int, List<int>> Map;
    private int MOD = (int)Math.Pow(10, 9) + 7;
    
    private void MapInit()
    {
        Map = new Dictionary<int, List<int>>();
        Map[0] = new List<int>{4, 6};
        Map[1] = new List<int>{6, 8};
        Map[2] = new List<int>{7, 9};
        Map[3] = new List<int>{4, 8};
        Map[4] = new List<int>{0, 3, 9};
        Map[5] = new List<int>();
        Map[6] = new List<int>{0, 1, 7};
        Map[7] = new List<int>{2, 6};
        Map[8] = new List<int>{1, 3};
        Map[9] = new List<int>{2, 4};
    }
    
    private int Recurse(int n, int curr, Dictionary<(int, int), int> memo)
    {
        if(n <= 1) return 1;
        
        if(memo.ContainsKey((n, curr))) return (memo[(n, curr)] % MOD);
        
        int ans = 0;
        foreach(var next in Map[curr]) 
        {
            ans = (ans + Recurse(n-1, next, memo)) % MOD;
        }
        return memo[(n, curr)] = ans;
    }
    
    public int KnightDialer(int n) 
    {
        MapInit();
        
        var memo = new Dictionary<(int, int), int>();
        var ans = 0;
        for(int i = 0; i < 10; i++)
        {
            ans = (ans + Recurse(n, i, memo)) % MOD;
        }
        return ans;
    }
}