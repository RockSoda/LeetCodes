public class Solution 
{
    public string SortSentence(string s) 
    {
        var sentence = new string[10];
        int prevIdx = -2;
        for(int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if(!char.IsDigit(c)) continue;

            sentence[c-'0'] = s.Substring(prevIdx+2, i-prevIdx-2);
            prevIdx = i;
        }

        var sb = new StringBuilder();
        foreach(var str in sentence)
        {
            if(string.IsNullOrEmpty(str)) continue;

            sb.Append(str);
            sb.Append(' ');
        }
        return sb.ToString().TrimEnd();
    }
}