public class Solution 
{
    public IList<string> ReadBinaryWatch(int turnedOn) 
    {
        if(turnedOn > 8) return new List<string>();
        
        Dictionary<int, List<string>> GetMap(int maxVal)
        {
            var map = new Dictionary<int, List<string>>();
            for(int i = 0; i <= maxVal; i++)
            {
                var binStr = Convert.ToString(i, 2);
                var numOfOnes = binStr.Count(c => c == '1');
                if(!map.ContainsKey(numOfOnes)) map[numOfOnes] = new List<string>();
                map[numOfOnes].Add(i.ToString());
            }
            return map;
        }
        
        var hourMap = GetMap(11);
        var minMap = GetMap(59);
        
        var numOfMins = turnedOn > 5 ? 5 : turnedOn;
        
        var listOfTime = new List<string>();
        
        for(var numOfHours = turnedOn - numOfMins; numOfHours < 4 && numOfHours <= turnedOn; numOfHours++)
        {
            var hourList = hourMap[numOfHours];
            var minList = minMap[numOfMins];
            
            foreach(var hour in hourList)
            {
                var prefix = hour + ":";
                minList.ForEach(min => {
                    var sb = new StringBuilder();
                    
                    sb.Append(prefix);
                    if(min.Length == 1) sb.Append("0");
                    sb.Append(min);
                    
                    listOfTime.Add(sb.ToString());
                });
            }
            
            numOfMins--;
        }
        
        return listOfTime;
    }
}