public class Solution 
{
    public int MinimumLength(string s) 
    {
        var map = new int[26];
        foreach(var c in s) map[c-'a']++;

        for(int i = 0; i < map.Length; i++)
        {
            var freq = map[i];
            if(freq < 3) continue;
            map[i] = freq % 2 == 0 ? 2 : 1;
        }

        return map.Sum();
    }
}