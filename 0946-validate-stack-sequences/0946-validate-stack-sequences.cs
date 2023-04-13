public class Solution 
{
    public bool ValidateStackSequences(int[] pushed, int[] popped) 
    {
        var stk = new Stack<int>();
        int indexPush = 0;
        int indexPop = 0;
        while(indexPush < pushed.Length && indexPop < popped.Length)
        {
            if(pushed[indexPush] == popped[indexPop])
            {
                indexPush++;
                indexPop++;
                continue;
            }
            
            if(stk.Count > 0 && stk.Peek() == popped[indexPop])
            {
                indexPop++;
                stk.Pop();
                continue;
            }
            
            stk.Push(pushed[indexPush++]);
        }
        
        while(stk.Count > 0 && indexPop < popped.Length)
            if(stk.Pop() != popped[indexPop++]) return false;
        
        return stk.Count == 0 && indexPop == popped.Length && indexPush == pushed.Length;
    }
}