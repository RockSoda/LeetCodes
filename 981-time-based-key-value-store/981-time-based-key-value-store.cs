public class TimeMap 
{
    private Dictionary<string, List<int>> KeyTimeMap;
    private Dictionary<(string, int), string> KeyValueMap;
    
    public TimeMap() 
    {
        KeyTimeMap = new Dictionary<string, List<int>>();
        KeyValueMap = new Dictionary<(string, int), string>();
    }
    
    public void Set(string key, string val, int timestamp) 
    {
        if(KeyTimeMap.ContainsKey(key)) KeyTimeMap[key].Add(timestamp);
        else KeyTimeMap.Add(key, new List<int>{ timestamp });
        
        KeyValueMap.Add((key, timestamp), val);
    }
    
    public string Get(string key, int timestamp) 
    {
        if(!KeyTimeMap.ContainsKey(key)) return string.Empty;
        
        var timeKey = SearchForTime(key, timestamp);
        
        if(timeKey == -1) return string.Empty;
        
        return KeyValueMap[(key, timeKey)];
    }
    
    private int SearchForTime(string key, int target)
    {
        var allTimestamps = KeyTimeMap[key];
        int left = 0;
        int right = allTimestamps.Count-1;
        
        while(left < right)
        {
            int mid = left + (right - left) / 2;
            
            if(allTimestamps[mid] < target) left = mid + 1;
            else if(allTimestamps[mid] > target) right = mid-1;
            else return allTimestamps[mid];
        }
        
        if(allTimestamps[left] > target) return left == 0 ? -1 : allTimestamps[left-1];
        
        return allTimestamps[left];
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */