public class Solution 
{
    public string SortVowels(string s) 
    {
        
        bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) >= 0;
        
        var vowels = new List<char>();
        var indexes = new List<int>();
        
        var charAry = new char[s.Length];
        
        for (int i = 0; i < s.Length; i++)
        {
            if (IsVowel(s[i]))
            {
                vowels.Add(s[i]);
                indexes.Add(i);
            }
            else charAry[i] = s[i];
        }
        
        if (vowels.Count == 0) return s;
        
        vowels.Sort();
        
        for(int i = 0; i < vowels.Count; i++) charAry[indexes[i]] = vowels[i];
        
        return new string(charAry);
    }
}