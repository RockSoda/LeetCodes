public class Solution 
{
    public string MergeAlternately(string word1, string word2) 
    {
        var sb = new StringBuilder();
        int len = word1.Length > word2.Length ? word1.Length : word2.Length;
        for(int i = 0; i < len; i++)
        {
            if(i < word1.Length) sb.Append(word1[i]);
            if(i < word2.Length) sb.Append(word2[i]);
        }
        
        return sb.ToString();
    }
}