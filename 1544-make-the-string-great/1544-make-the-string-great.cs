public class Solution 
{
    public string MakeGood(string s) 
    {
        var stk = new Stack<char>();
        
        foreach(var c in s)
        {
            char prev = stk.Count > 0 ? stk.Peek() : '.';
            
            bool isBad = (Char.IsUpper(c) && Char.IsLower(prev)) || 
                         (Char.IsUpper(prev) && Char.IsLower(c));
            
            if(isBad && Char.ToUpper(c) == Char.ToUpper(prev)) stk.Pop();
            else stk.Push(c);
        }
        
        var sb = new StringBuilder();
        while(stk.Count > 0) sb.Insert(0, stk.Pop());
        
        return sb.ToString();
    }
}