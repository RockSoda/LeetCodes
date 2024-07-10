public class Solution 
{
    public int MinOperations(string[] logs) 
    {
        var stk = new Stack<object>();
        foreach(var log in logs)
        {
            switch(log)
            {
                case "./":
                    break;
                case "../":
                    if(stk.Count > 0) stk.Pop();
                    break;
                default:
                    stk.Push(null);
                    break;
            }
        }
        
        return stk.Count;
    }
}