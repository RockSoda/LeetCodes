public class Solution 
{
    public int MinOperations(string[] logs) 
    {
        var stk = new Stack<bool>();
        foreach(var log in logs)
        {
            if(log.Equals("../"))
            {
                if(stk.Count > 0) stk.Pop();
            }
            else if(log.Equals("./")) continue;
            else stk.Push(true);
        }
        
        return stk.Count;
    }
}