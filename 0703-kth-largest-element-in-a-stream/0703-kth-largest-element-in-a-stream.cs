public class KthLargest 
{
    private List<int> _list;
    private int _k;
    
    public KthLargest(int k, int[] nums) 
    {
        _k = k;
        _list = nums.ToList();
        _list.Sort();
        _list.Reverse();
    }
    
    private int FindIndexToInsert(int val)
    {
        int left = 0, right = _list.Count - 1;
        
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if(_list[mid] < val) right = mid - 1;
            else if(_list[mid] > val) left = mid + 1;
            else return mid;
        }
        
        return left;
    }
    
    public int Add(int val) 
    {
        _list.Insert(FindIndexToInsert(val), val);
        
        return _list[_k-1];
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */