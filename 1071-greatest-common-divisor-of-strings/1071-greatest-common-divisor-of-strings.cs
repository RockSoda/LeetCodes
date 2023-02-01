public class Solution 
{
    public string GcdOfStrings(string str1, string str2) 
    {
        int size = str1.Length > str2.Length ? str1.Length : str2.Length;
        var sb = new StringBuilder();
        string output = string.Empty;
        for(int i = 0; i < size; i++)
        {
            char c1 = str1.Length > i ? str1[i] : '\0';
            char c2 = str2.Length > i ? str2[i] : '\0';
            
            if(c1 != c2) break;
            
            sb.Append(c1);
            
            var rgx = new System.Text.RegularExpressions.Regex("^(" + sb.ToString() + ")+$");
            if(rgx.IsMatch(str1) && rgx.IsMatch(str2)) output = sb.ToString();
        }
        
        return output;
    }
}