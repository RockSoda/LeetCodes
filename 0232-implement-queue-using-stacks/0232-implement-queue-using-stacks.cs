public class MyQueue 
{

    private Stack<int> _stkIn;
    private Stack<int> _stkOut;
    
    public MyQueue() 
    {
        _stkIn = new Stack<int>();
        _stkOut = new Stack<int>();
    }
    
    public void Push(int x) 
    {
        _stkIn.Push(x);
    }
    
    private void Channel(Stack<int> stkFrom, Stack<int> stkTo)
    {
        while(stkFrom.Count > 0) stkTo.Push(stkFrom.Pop());
    }
    
    public int Pop() 
    {
        if(_stkOut.Count == 0) Channel(_stkIn, _stkOut);
        
        return _stkOut.Pop();
    }
    
    public int Peek() 
    {
        if(_stkOut.Count == 0) Channel(_stkIn, _stkOut);
        
        return _stkOut.Peek();
    }
    
    public bool Empty() => _stkIn.Count == 0 && _stkOut.Count == 0;
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */