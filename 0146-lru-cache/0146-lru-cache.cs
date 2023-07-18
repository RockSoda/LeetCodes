public class LRUCache 
{
    private Dictionary<int, int> _cacheTime;
    private Dictionary<int, int> _timeCache;
    private Dictionary<int, int> _map;
    private HashSet<int> _removedTime;
    private int _size;
    private int _time;
    private int _earliest;
    
    private void UpdateCache(int key)
    {
        if (_cacheTime.ContainsKey(key))
        {
            _timeCache.Remove(_cacheTime[key]);
            _removedTime.Add(_cacheTime[key]);
        }
        
        _timeCache[_time] = key;
        _cacheTime[key] = _time++;
    }
    
    public LRUCache(int capacity) 
    {
        _cacheTime = new Dictionary<int, int>();
        _timeCache = new Dictionary<int, int>();
        _map = new Dictionary<int, int>();
        _removedTime = new HashSet<int>();
        _size = capacity;
        _time = 0;
        _earliest = 0;
    }
    
    public int Get(int key) 
    {
        if(!_map.ContainsKey(key)) return -1;
        
        UpdateCache(key);
        
        return _map[key];
    }
    
    public void Put(int key, int value) 
    {
        if(_map.Count == _size && !_map.ContainsKey(key))
        {
            while(_removedTime.Contains(_earliest)) _earliest++;
            var toBeRemoved = _timeCache[_earliest];
            _map.Remove(toBeRemoved);
            _cacheTime.Remove(toBeRemoved);
            _timeCache.Remove(_earliest);
            while(_removedTime.Contains(++_earliest));
        }
        
        UpdateCache(key);
        _map[key] = value;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */