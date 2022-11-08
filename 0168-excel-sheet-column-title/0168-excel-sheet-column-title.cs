public class Solution 
{
    public string ConvertToTitle(int columnNumber) 
    {
        var sb = new StringBuilder();
        
        while(columnNumber > 0)
        {
            int remainder = columnNumber % 26;
            
            columnNumber /= 26;
            
            if(remainder == 0)
            {
                remainder = 26;
                columnNumber--;
            }
            
            sb.Insert(0, (char)(remainder - 1 + 'A'));
        }
        
        return sb.ToString();
    }
}