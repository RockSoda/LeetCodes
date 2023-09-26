public class Solution 
{
    public string RemoveDuplicateLetters(string s) 
    {
        var stk = new Stack<char>();
        var map = new int[26];
        var seen = new bool[26];
        
        for(int i = 0; i < s.Length; i++) map[s[i]-'a'] = i;
        
        for(int i = 0; i < s.Length; i++)
        {
            char cur = s[i];
            
            if(seen[cur-'a']) continue;
            
            while(stk.Count > 0 && cur < stk.Peek() && map[stk.Peek()-'a'] > i)
            {
                seen[stk.Peek()-'a'] = false;
                stk.Pop();
            }
            stk.Push(cur);
            seen[cur-'a'] = true;
        }
        
        var ans = new StringBuilder();
        while(stk.Count > 0) ans.Insert(0, stk.Pop());
        
        return ans.ToString();
    }
}