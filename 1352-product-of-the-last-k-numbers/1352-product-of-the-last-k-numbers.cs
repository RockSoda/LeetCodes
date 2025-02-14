public class ProductOfNumbers 
{
    private List<long> prefix;

    public ProductOfNumbers() 
    {
        prefix = new List<long>();
    }
    
    public void Add(int num) 
    {   
        if(num == 0) 
        {
            prefix.Clear();
            return;
        }

        var curr = (long)num;

        if(prefix.Count == 0) prefix.Add(curr);
        else prefix.Add(prefix.Last() * curr);
    }
    
    public int GetProduct(int k) 
    {
        int idx = prefix.Count - k - 1;
        if(idx == -1) return (int)prefix.Last();
        
        if(idx < 0) return 0;

        return (int)(prefix.Last() / prefix[idx]);
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */