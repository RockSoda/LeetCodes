public class Solution 
{
    public int AddDigits(int num) 
    {
        var str = num.ToString();
        while(str.Length > 1)
        {
            var sum = 0;
            
            foreach(var c in str) sum += c-'0';
            
            str = sum.ToString();
        }
        
        return int.Parse(str);
    }
}