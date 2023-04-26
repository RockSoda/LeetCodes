public class Solution 
{
    public int GetLucky(string s, int k) 
    {
        var sb = new StringBuilder();
        foreach(var c in s)
            sb.Append((c-'a'+1).ToString());
        
        var str = sb.ToString();
        
        for(int i = 0; i < k; i++)
        {
            var sum = 0;
            
            foreach(var c in str) sum += c-'0';
            
            str = sum.ToString();
        }
        
        return int.Parse(str);
    }
}