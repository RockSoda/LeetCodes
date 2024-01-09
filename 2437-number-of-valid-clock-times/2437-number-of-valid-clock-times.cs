public class Solution 
{
    public int CountTime(string time) 
    {
        var ary = time.Split(":");
        
        int hours = 1;
        //"??:xx"
        if(ary[0][0] == '?' && ary[0][1] == '?') hours = 24;
        else
        {
            //"?x:xx"
            if(ary[0][0] == '?')
            {
                if(ary[0][1] - '0' <= 3) hours = 3;
                else hours = 2;
            }
            
            //"x?:xx"
            else if(ary[0][1] == '?')
            {
                if(ary[0][0] - '0' == 2) hours = 4;
                else hours = 10;
            }
        }
        
        int minute = 1;
        //"xx:??"
        if(ary[1][0] == '?' && ary[1][1] == '?') minute = 60;
        else
        {
            //"xx:?x"
            if(ary[1][0] == '?') minute = 6;
            
            //"xx:x?"
            else if(ary[1][1] == '?') minute = 10;
        }
        
        return hours*minute;
    }
}