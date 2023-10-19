public class Solution 
{
    public bool BackspaceCompare(string s, string t) 
    {
        Stack<char> GetStkFromStr(string str)
        {
            var stk = new Stack<char>();
            
            foreach(var c in str)
            {
                if(c != '#') stk.Push(c);
                else if(stk.Count > 0) stk.Pop();
            }
            
            return stk;
        }
        
        var stks = GetStkFromStr(s);
        var stkt = GetStkFromStr(t);
        
        if(stks.Count != stkt.Count) return false;
        
        while(stks.Count > 0 && stkt.Count > 0)
        {
            if(stks.Pop() != stkt.Pop()) return false;
        }
        
        return true;
    }
}