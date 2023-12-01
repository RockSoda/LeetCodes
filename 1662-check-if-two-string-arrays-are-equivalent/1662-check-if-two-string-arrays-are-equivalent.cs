public class Solution 
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) 
    {
        int idx1 = 0, idx2 = 0;
        
        var sb1 = new StringBuilder();
        var sb2 = new StringBuilder();
        
        while(idx1 < word1.Length || idx2 < word2.Length)
        {
            string curr1 = idx1 < word1.Length ? word1[idx1++] : string.Empty;
            string curr2 = idx2 < word2.Length ? word2[idx2++] : string.Empty;
            
            sb1.Append(curr1);
            sb2.Append(curr2);
        }
        
        return string.Compare(sb1.ToString(), sb2.ToString()) == 0;
    }
}