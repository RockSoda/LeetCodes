public class Solution 
{
    private void RemoveInstance(Dictionary<string, int> map, string key)
    {
        if(!map.ContainsKey(key)) return;
        
        if(--map[key] == 0) map.Remove(key);
    }
    
    private bool IsRepetedTwo(string word) => word[0] == word[1];
    
    private string ReverseStr(string str) => new string(new char[]{ str[1], str[0] });
    
    public int LongestPalindrome(string[] words) 
    {
        var map = new Dictionary<string, int>();
        
        for(int i = 0; i < words.Length; i++)
            map[words[i]] = map.ContainsKey(words[i]) ? map[words[i]]+1 : 1;
        
        int counter = 0;
        
        var keys = map.Keys.ToList();
        
        foreach(var key in keys)
        {
            int val = map.ContainsKey(key) ? map[key] : -1;
            
            for(int i = 0; i < val; i++)
            {
                if(map.ContainsKey(ReverseStr(key)))
                {
                    if(IsRepetedTwo(key))
                    {
                        if(map[key] > 1)
                        {
                            counter += 4;
                            RemoveInstance(map, key);
                            RemoveInstance(map, key);
                        }
                    }
                    else
                    {
                        counter += 4;
                        RemoveInstance(map, ReverseStr(key));
                        RemoveInstance(map, key);
                    }
                }
            }
        }
        
        foreach(var kvp in map)
        {
            if(IsRepetedTwo(kvp.Key))
            {
                counter += 2;
                break;
            }
        }
        
        return counter;
    }
}