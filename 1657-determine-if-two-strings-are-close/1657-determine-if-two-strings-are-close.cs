public class Solution 
{
    public bool CloseStrings(string word1, string word2) 
    {
        if(word1.Length != word2.Length) return false;
        
        var map1 = new int[26];
        var map2 = new int[26];
        
        foreach(var c in word1) map1[c-'a']++;
        foreach(var c in word2) map2[c-'a']++;
        
        var freqMap = new Dictionary<int, int>();
        
        for(int i = 0; i < 26; i++)
        {
            if(map1[i] != map2[i] && (map1[i] == 0 || map2[i] == 0)) return false;
            if(map1[i] != 0) 
                freqMap[map1[i]] = freqMap.ContainsKey(map1[i]) ? freqMap[map1[i]]+1 : 1;
        }
        
        for(int i = 0; i < 26; i++)
        {
            if(map2[i] != 0)
            {
                if(!freqMap.ContainsKey(map2[i])) return false;
                
                freqMap[map2[i]]--;
                if(freqMap[map2[i]] == 0) freqMap.Remove(map2[i]);
            }
        }
        
        return freqMap.Count == 0;
    }
}