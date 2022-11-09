public class StockSpanner 
{
    private Stack<(int stock, int freq)> monotonicStk;
    
    public StockSpanner() 
    {
        monotonicStk = new Stack<(int, int)>();
    }
    
    public int Next(int price) 
    {
        int counter = 1;
        while(monotonicStk.Count > 0 && price >= monotonicStk.Peek().stock) 
            counter += monotonicStk.Pop().freq;
        
        monotonicStk.Push((price, counter));
        return counter;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */