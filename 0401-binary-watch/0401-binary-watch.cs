public class Solution 
{
    public IList<string> ReadBinaryWatch(int turnedOn) 
    {
        if(turnedOn > 8) return new List<string>();
        
        Dictionary<int, List<int>> GetMap(int maxVal)
        {
            var map = new Dictionary<int, List<int>>();
            for(int i = 0; i <= maxVal; i++)
            {
                var binStr = Convert.ToString(i, 2);
                var numOfOnes = binStr.Count(c => c == '1');
                if(!map.ContainsKey(numOfOnes)) map[numOfOnes] = new List<int>();
                map[numOfOnes].Add(i);
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
                var hourStr = hour.ToString()+":";
                minList.ForEach(min => {
                    var minSb = new StringBuilder();
                    minSb.Append(hourStr.ToString());
                    var minStr = min.ToString();
                    if(minStr.Length == 1) minSb.Append("0");
                    minSb.Append(minStr);
                    listOfTime.Add(minSb.ToString());
                });
            }
            
            numOfMins--;
        }
        
        return listOfTime;
    }
}