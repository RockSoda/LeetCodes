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
        if (q2.Count == 0)
        {
            Channel(q1, q2);
            return q1.Dequeue();
        }
        else
        {
            Channel(q2, q1);
            return q2.Dequeue();
        }
    }
    
    public int Top() 
    {
        if (q2.Count == 0)
        {
            Channel(q1, q2);
            var top = q1.Dequeue();
            q2.Enqueue(top);
            return top;
        }
        else
        {
            Channel(q2, q1);
            var top = q2.Dequeue();
            q1.Enqueue(top);
            return top;
        }
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