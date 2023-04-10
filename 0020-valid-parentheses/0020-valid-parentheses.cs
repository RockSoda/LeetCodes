public class Solution 
{
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
                    if(stk.Count == 0 || stk.Pop() != '(') return false;
                    break;
                case '}':
                    if(stk.Count == 0 || stk.Pop() != '{') return false;
                    break;
                case ']':
                    if(stk.Count == 0 || stk.Pop() != '[') return false;
                    break;
                default:
                    break;
            }
        }
        
        return stk.Count == 0;
    }
}