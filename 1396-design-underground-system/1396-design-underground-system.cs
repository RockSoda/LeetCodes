public class UndergroundSystem 
{
    private Dictionary<int, (string stationIn, int timeIn)> _passengerMap;
    private Dictionary<(string stationIn, string stationOut), List<int>> _timeMap;
    
    public UndergroundSystem() 
    {
        _passengerMap = new Dictionary<int, (string, int)>();
        _timeMap = new Dictionary<(string stationIn, string stationOut), List<int>>();
    }
    
    public void CheckIn(int id, string stationName, int t) 
    {
        _passengerMap[id] = (stationName, t);
    }
    
    public void CheckOut(int id, string stationName, int t) 
    {
        var timeIn = _passengerMap[id].timeIn;
        var stationIn = _passengerMap[id].stationIn;
        
        if(!_timeMap.ContainsKey((stationIn, stationName)))
            _timeMap[(stationIn, stationName)] = new List<int>();
        
        _timeMap[(stationIn, stationName)].Add(t - timeIn);
    }
    
    public double GetAverageTime(string startStation, string endStation) 
    {
        if(!_timeMap.ContainsKey((startStation, endStation))) return 0;
        
        return _timeMap[(startStation, endStation)].Average();
    }
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */