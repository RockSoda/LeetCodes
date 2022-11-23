public class Solution 
{
    public string MaximumTime(string time) 
    {
        var timeAry = time.Split(":");
        var hours = timeAry[0].ToCharArray();
        var minutes = timeAry[1].ToCharArray();
        
        if(hours[0] == '?')
        {
            if(char.IsDigit(hours[1]))
            {
                if(hours[1] <= '3') hours[0] = '2';
                else hours[0] = '1';
            }
            else hours[0] = '2';
        }
        
        if(hours[1] == '?')
        {
            if(hours[0] <= '1') hours[1] = '9';
            else hours[1] = '3';
        }
        
        if(minutes[0] == '?') minutes[0] = '5';
        
        if(minutes[1] == '?') minutes[1] = '9';
        
        return new string(hours) + ":" + new string(minutes);
    }
}