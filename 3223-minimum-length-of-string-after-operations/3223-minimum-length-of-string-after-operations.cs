public class Solution 
{
    public int MinimumLength(string s) 
    {
        var map = new int[26];
        foreach(var c in s) map[c-'a']++;

        var len = 0;
        for(int i = 0; i < map.Length; i++)
        {
            var freq = map[i];
            if (freq >= 3) freq = freq % 2 == 0 ? 2 : 1;
            len += freq;
        }

        return len;
    }
}