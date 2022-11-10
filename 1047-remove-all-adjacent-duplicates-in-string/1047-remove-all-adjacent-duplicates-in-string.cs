public class Solution 
{
    public string RemoveDuplicates(string s) 
    {
        var stk = new Stack<char>();
        foreach(var c in s)
        {
            if(stk.Count > 0 && c == stk.Peek()) stk.Pop(); 
            else stk.Push(c);
        }
        
        var list = stk.ToList();
        list.Reverse();
        return new string(list.ToArray());
    }
}