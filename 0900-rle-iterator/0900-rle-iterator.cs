public class RLEIterator 
{
    private int index;
    private int curr;
    private int[] coded;
    public RLEIterator(int[] encoding) 
    {
        coded = encoding.ToArray();
        curr = 0;
        index = 0;
    }
    
    public int Next(int n) 
    {
        int toReturn = -1;
        while(n > 0 && curr < coded.Length)
        {
            toReturn = coded[curr+1];
            if(coded[curr] <= n)
            {
                n -= coded[curr];
                curr += 2;
            }
            else
            {
                coded[curr] -= n;
                n = 0;
            }
        }
        
        if(n > 0) return -1;
        
        return toReturn;
    }
}

/**
 * Your RLEIterator object will be instantiated and called as such:
 * RLEIterator obj = new RLEIterator(encoding);
 * int param_1 = obj.Next(n);
 */