public class Solution 
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) 
    {
        int idx1 = 0, idx2 = 0;
        
        var sb1 = new StringBuilder();
        var sb2 = new StringBuilder();
        
        void Process(ref int idx, ref StringBuilder sb, string[] word)
        {
            string curr = idx < word.Length ? word[idx++] : string.Empty;
            sb.Append(curr);
        }
        
        while(idx1 < word1.Length || idx2 < word2.Length)
        {
            Process(ref idx1, ref sb1, word1);
            Process(ref idx2, ref sb2, word2);
        }
        
        return string.Compare(sb1.ToString(), sb2.ToString()) == 0;
    }
}