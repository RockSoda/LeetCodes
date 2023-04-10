public class Solution 
{
    private bool CannotPop(Stack<char> stk, char c) =>
        stk.Count == 0 || stk.Pop() != c;
    
    public bool IsValid(string s) 
    {
        var stk = new Stack<char>();
        foreach(var c in s)
        {
            switch(c)
            {
                case '(':
                case '{':
                case '[':
                    stk.Push(c);
                    break;
                case ')':
                    if(CannotPop(stk, '(')) return false;
                    break;
                case '}':
                    if(CannotPop(stk, '{')) return false;
                    break;
                case ']':
                    if(CannotPop(stk, '[')) return false;
                    break;
                default:
                    break;
            }
        }
        
        return stk.Count == 0;
    }
}