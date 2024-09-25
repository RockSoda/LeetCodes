public class Solution 
{
    public int[] SumPrefixScores(string[] words) 
    {
        string GetCommonPrefix(string str1, string str2)
        {
            var sb = new StringBuilder();
            int len = str1.Length > str2.Length ? str2.Length : str1.Length;
            for(int i = 0; i < len; i++)
            {
                if(str1[i] == str2[i]) sb.Append(str1[i]);
                else break;
            }
            return sb.ToString();
        }

        var scores = new int[words.Length];
        for(int i = 0; i < words.Length; i++)
        {
            var str1 = words[i];
            scores[i] += str1.Length;
            for(int j = i+1; j < words.Length; j++)
            {
                var str2 = words[j];

                var commonPrefix = GetCommonPrefix(str1, str2);

                if(string.IsNullOrEmpty(commonPrefix)) continue;
                
                scores[i] += commonPrefix.Length;
                scores[j] += commonPrefix.Length;
            }
        }
        return scores;
    }
}