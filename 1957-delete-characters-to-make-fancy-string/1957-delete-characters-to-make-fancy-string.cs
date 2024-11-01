public class Solution 
{
    public string MakeFancyString(string s) 
    {
        if(s.Length < 3) return s;
        var sb = new StringBuilder();
        sb.Append(s[0]);
        sb.Append(s[1]);
        for(int i = 2; i < s.Length; i++)
        {
            var c = s[i];
            if(c == s[i-2] && c == s[i-1]) continue;
            sb.Append(c);
        }

        return sb.ToString();
    }
}