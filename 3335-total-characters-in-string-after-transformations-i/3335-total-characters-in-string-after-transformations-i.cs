public class Solution 
{
    private int MOD = (int)Math.Pow(10, 9) + 7;
    public int LengthAfterTransformations(string s, int t) 
    {
        var map = new int[26];

        foreach(var c in s) map[c-'a']++;
        
        for(int times = 0; times < t; times++)
        {
            int prev = map[0];
            for (int i = 1; i < 26; i++) (map[i], prev) = (prev, map[i]);

            map[0] = prev;
            map[1] = (map[1] + prev) % MOD;
        }

        long len = 0;
        foreach(int num in map) len += num;

        return (int)(len % MOD);
    }
}