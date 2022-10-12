public class RecentCounter 
{
    private int currIndex;
    private List<int> list;
    public RecentCounter() 
    {
        currIndex = 0;
        list = new List<int>();
    }
    
    public int Ping(int t) 
    {
        int left = t - 3000;
        int right = t;
        list.Add(t);
        
        while(list[currIndex] < left) currIndex++;
        
        return list.Count - currIndex;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */