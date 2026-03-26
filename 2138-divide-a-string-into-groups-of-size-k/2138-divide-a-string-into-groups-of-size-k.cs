public class Solution 
{
    public string[] DivideString(string s, int k, char fill) 
    {
        var mod = s.Length % k;
        var size = s.Length / k + (mod == 0 ? 0 : 1);
        var output = new string[size];
        var idx = 0;
        for (int i = 0; i < size; i++)
        {
            var sb = new StringBuilder();
            for (int j = 0; j < k; j++) sb.Append(idx+j < s.Length ? s[idx+j] : fill);
            idx += k;
            output[i] = sb.ToString();
        }
        return output;
    }
}