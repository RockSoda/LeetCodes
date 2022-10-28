public class Solution 
{
    public int MinAddToMakeValid(string s) 
    {
        int counter = 0;
        var stk = new Stack<bool>();
        foreach(var c in s)
        {
            if(c == '(') stk.Push(true);
            else
            {
                if(stk.Count == 0) counter++;
                else stk.Pop();
            }
        }
        
        return counter + stk.Count;
    }
}