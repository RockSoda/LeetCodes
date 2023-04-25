public class SmallestInfiniteSet 
{
    private HashSet<int> _poppedSet;
    private List<int> _addedBack;
    private int _currSmallest;
    
    public SmallestInfiniteSet() 
    {
        _poppedSet = new HashSet<int>();
        _addedBack = new List<int>();
        _currSmallest = 1;
    }
    
    public int PopSmallest() 
    {
        if (_addedBack.Count <= 0)
        {
            _poppedSet.Add(_currSmallest);
            return _currSmallest++;
        }
        
        var poppedFromAdded = _addedBack.First();
        _addedBack.RemoveAt(0);
        _poppedSet.Add(poppedFromAdded);
        return poppedFromAdded;
    }
    
    public void AddBack(int num) 
    {
        if(!_poppedSet.Contains(num)) return;
        
        _poppedSet.Remove(num);
        
        _addedBack.Insert(FindIndex(_addedBack, num), num);
    }
    
    /*private int FindIndex(List<int> list, int num)
    {
        for(int i = 0; i < list.Count; i++)
        {
            if(list[i] > num) return i;
        }
        
        return list.Count;
    }*/
    private int FindIndex(List<int> list, int num)
    {
        int left = 0, right = list.Count - 1;
        
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if(list[mid] > num) right = mid - 1;
            else if(list[mid] < num) left = mid + 1;
            else return mid;
        }
        
        return left;
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */