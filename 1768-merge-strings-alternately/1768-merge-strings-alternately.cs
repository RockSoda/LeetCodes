public class Solution 
{
    public string MergeAlternately(string word1, string word2) 
    {
        var sb = new StringBuilder();
        int len = word1.Length > word2.Length ? word1.Length : word2.Length;
        for(int i = 0; i < len; i++)
        {
            char c1 = i < word1.Length ? word1[i] : '-';
            char c2 = i < word2.Length ? word2[i] : '-';
            
            if(c1 != '-') sb.Append(c1);
            if(c2 != '-') sb.Append(c2);
        }
        
        return sb.ToString();
    }
}