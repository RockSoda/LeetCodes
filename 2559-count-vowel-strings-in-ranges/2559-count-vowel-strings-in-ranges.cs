public class Solution 
{
    public int[] VowelStrings(string[] words, int[][] queries) 
    {
        bool IsVowel(char c) =>
            c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';

        var prefixSum = new int[words.Length];
        prefixSum[0] = IsVowel(words[0].First()) && IsVowel(words[0].Last()) ? 1 : 0;
        for(int i = 1; i < words.Length; i++)
        {
            var word = words[i];
            prefixSum[i] = prefixSum[i-1] + (IsVowel(word.First()) && IsVowel(word.Last()) ? 1 : 0);
        }
        var ans = new int[queries.Length];
        int idx = 0;
        foreach(var query in queries)
        {
            int l = query[0] - 1, r = query[1];
            ans[idx++] = prefixSum[r] - (l < 0 ? 0 : prefixSum[l]);
        }
        return ans;
    }
}