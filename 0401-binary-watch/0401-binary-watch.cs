public class Solution 
{
    public IList<string> ReadBinaryWatch(int turnedOn) 
    {
        if(turnedOn > 8) return new List<string>();
        
        var hourMap = new Dictionary<int, List<string>>();
        var minMap = new Dictionary<int, List<string>>();
        
        for(int i = 0; i <= 59; i++)
        {
            var binStr = Convert.ToString(i, 2);
            var numOfOnes = binStr.Count(c => c == '1');
                
            if(!minMap.ContainsKey(numOfOnes)) minMap[numOfOnes] = new List<string>();
                
            minMap[numOfOnes].Add(i.ToString());
            
            if(i > 11) continue;
                
            if(!hourMap.ContainsKey(numOfOnes)) hourMap[numOfOnes] = new List<string>();
                
            hourMap[numOfOnes].Add(i.ToString());
        }
        
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
                    
                    sb.Append(prefix.ToString());
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