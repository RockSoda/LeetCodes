public class Solution 
{
    public int CountEven(int num)
    {
        var counter = 0;
        
        for(int i = 1; i <= num; i++)
        {
            var sum = 0;
            var str = i.ToString();
            
            foreach(var c in str) sum += c-'0';
            
            if(sum % 2 == 0) counter++;
        }
        
        return counter;
    }
}