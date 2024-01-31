public class Solution 
{
    public int[] DailyTemperatures(int[] temperatures) 
    {
        var output = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++)
        {
            var current = temperatures[i];
            for(int j = i + 1; j < temperatures.Length; j++)
            {
                var future = temperatures[j];
                if(current >= future) continue;
                    
                output[i] = j-i;
                break;
            }
        }
        
        return output;
    }
}