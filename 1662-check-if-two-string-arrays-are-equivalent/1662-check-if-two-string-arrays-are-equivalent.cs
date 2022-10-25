public class Solution 
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) 
    {
        int size = word1.Length > word2.Length ? word1.Length : word2.Length;
        int index = 0;
        var sb1 = new StringBuilder();
        var sb2 = new StringBuilder();
        while(index < size)
        {
            sb1.Append(index < word1.Length ? word1[index] : "");
            sb2.Append(index < word2.Length ? word2[index] : "");
            
            index++;
        }
        return sb1.ToString().Equals(sb2.ToString());
    }
}