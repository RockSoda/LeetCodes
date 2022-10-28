public class Solution 
{
    public bool CheckInclusion(string s1, string s2) 
    {
        var map = new int[26];
        foreach(var c in s1) map[c-'a']++;
        
        for(int i = 0; i < s2.Length-s1.Length+1; i++)
        {
            var currMap = map.ToArray();
            bool flag = true;
            for(int j = 0; j < s1.Length; j++)
            {
                
                if(--currMap[s2[i+j]-'a'] < 0)
                {
                    flag = false;
                    break;
                }
            }
            
            flag = flag && currMap.Count(x => x != 0) == 0;
            
            if(flag) return true;
        }
        
        return false;
    }
}