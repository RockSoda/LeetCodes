public class Solution 
{
    public string LargestGoodInteger(string num) 
    {
        string GetStr (int digit)
        {
            if (digit == -1) return string.Empty;
            
            var sb = new StringBuilder();
            sb.Append((char)('0' + digit), 3);
            return sb.ToString();
        }
        
        int largest = -1;
        for (int i = 2; i < num.Length; i++)
        {
            if (num[i] != num[i-1] || num[i] != num[i-2]) continue;
            
            if (largest < num[i] - '0') largest = num[i] - '0';
        }
        
        return GetStr(largest);
    }
}