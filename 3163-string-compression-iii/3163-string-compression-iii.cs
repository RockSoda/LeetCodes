public class Solution 
{
    public string CompressedString(string word) 
    {
        var stk = new Stack<char>();
        var sb = new StringBuilder();
        foreach(var c in word)
        {
            if (stk.Count > 0 && (stk.Peek() != c || stk.Count >= 9))
            {
                sb.Append(stk.Count.ToString());
                sb.Append(stk.Peek());
                stk.Clear();
            }

            stk.Push(c);
        }
        
        sb.Append(stk.Count.ToString());
        sb.Append(stk.Peek());

        return sb.ToString();
    }
}