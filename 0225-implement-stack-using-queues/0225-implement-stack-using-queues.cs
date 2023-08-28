public class MyStack 
{

    Queue<int> q1, q2;
    
    public MyStack() 
    {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }
    
    public void Push(int x) 
    {
        if (q2.Count == 0) q1.Enqueue(x);
        else q2.Enqueue(x);
    }
    
    public int Pop() 
    {
        var fromQ = q2.Count == 0 ? q1 : q2;
        var toQ = q2.Count == 0 ? q2 : q1;
        
        Channel(fromQ, toQ);
        return fromQ.Dequeue();
    }
    
    public int Top() 
    {
        var fromQ = q2.Count == 0 ? q1 : q2;
        var toQ = q2.Count == 0 ? q2 : q1;
        
        Channel(fromQ, toQ);
        var top = fromQ.Dequeue();
        toQ.Enqueue(top);
        return top;
    }
    
    private void Channel(Queue<int> fromQ, Queue<int> toQ)
    {
        while(fromQ.Count > 1)
        {
            toQ.Enqueue(fromQ.Dequeue());
        }
    }
    
    public bool Empty() => q1.Count == 0 && q2.Count == 0;
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */