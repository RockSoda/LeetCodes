public class Solution 
{
    public int FirstUniqChar(string s) 
    {
        var map = new (int idx, int freq)[26];
        for(int i = 0; i < s.Length; i++)
        {
            var idx = s[i]-'a';
            var freq = map[idx].freq;
            map[idx] = (i, freq+1);
        }
        
        var unique = map.Where(pair => pair.freq == 1);
        if(unique.Count() == 0) return -1;
        
        return unique.Min(pair => pair.idx);
    }
}