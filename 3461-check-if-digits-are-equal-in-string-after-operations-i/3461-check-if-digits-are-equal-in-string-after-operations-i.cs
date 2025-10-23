public class Solution 
{
    public bool HasSameDigits(string s) 
    {
        while(s.Length > 2)
        {
            var sb = new StringBuilder();
            for(int i = 1; i < s.Length; i++)
            {
                sb.Append((s[i-1]-'0' + s[i]-'0') % 10);
            }
            s = sb.ToString();
        }
        return s[0] == s[1];
    }
}