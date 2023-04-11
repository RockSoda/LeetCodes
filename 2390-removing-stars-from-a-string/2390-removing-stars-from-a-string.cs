public class Solution 
{
    public string RemoveStars(string s) 
    {
        var stk = new Stack<char>();
        foreach(var c in s)
            stk.Push(c);
        
        var sb = new StringBuilder();
        
        int counter = 0;
        while(stk.Count > 0)
        {
            if(stk.Peek() != '*') sb.Insert(0, stk.Pop());
            else
            {
                while(stk.Peek() == '*')
                {
                    counter++;
                    stk.Pop();
                }
                
                for(; counter > 0 && stk.Peek() != '*'; counter--) stk.Pop();
            }
        }
        
        return sb.ToString();
    }
}