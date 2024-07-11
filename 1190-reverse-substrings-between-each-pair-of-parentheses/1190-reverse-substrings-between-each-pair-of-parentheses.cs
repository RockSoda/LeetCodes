public class Solution 
{
    public string ReverseParentheses(string s) 
    {
        var stk = new Stack<string>();
        var sb = new StringBuilder();
        
        foreach(var c in s)
        {
            switch(c)
            {
                case '(':
                    stk.Push(sb.ToString());
                    sb.Clear();
                    break;
                case ')':
                    sb = new StringBuilder(new string(sb.ToString().Reverse().ToArray()));
                    if(stk.Count > 0) sb.Insert(0, stk.Pop());
                    break;
                default:
                    sb.Append(c);
                    break;
            }
        }
        
        return sb.ToString();
    }
}