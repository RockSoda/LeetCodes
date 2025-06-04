public class Solution 
{
    public string AnswerString(string word, int numFriends)
    {
        if(numFriends == 1) return word;

        var maxSubLen = word.Length - numFriends + 1;
        var maxSubstr = string.Empty;
        for(int i = 0; i < word.Length; i++)
        {
            var currLen = Math.Min(maxSubLen, word.Length - i);
            var substr = word.Substring(i, currLen);
            if(string.Compare(substr, maxSubstr) > 0) maxSubstr = substr;
        }
        return maxSubstr;
    }
}