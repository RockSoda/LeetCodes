public class SnapshotArray 
{
    List<Dictionary<int, int>> _listOfMap;
    
    public SnapshotArray(int length) 
    {
        _listOfMap = new List<Dictionary<int, int>>();
        _listOfMap.Add(new Dictionary<int, int>());
    }
    
    public void Set(int index, int val) 
    {
        int snapId = _listOfMap.Count - 1;
        _listOfMap[snapId][index] = val;
    }
    
    public int Snap()
    {
        _listOfMap.Add(new Dictionary<int, int>());
        return _listOfMap.Count - 2;
    }
    
    public int Get(int index, int snap_id)
    {
        for (int snap = snap_id; snap >= 0; snap--) 
        {
            if (_listOfMap[snap].ContainsKey(index))
                return _listOfMap[snap][index];
        }
        return 0;
    }
}

/**
 * Your SnapshotArray object will be instantiated and called as such:
 * SnapshotArray obj = new SnapshotArray(length);
 * obj.Set(index,val);
 * int param_2 = obj.Snap();
 * int param_3 = obj.Get(index,snap_id);
 */