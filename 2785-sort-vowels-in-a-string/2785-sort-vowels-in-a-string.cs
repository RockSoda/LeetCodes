public class Solution 
{
    public string SortVowels(string s) 
    {
        var vowelSet = new HashSet<char>
        {
            'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'
        };

        var vowels = new List<char>();
        var indexes = new List<int>();
        
        var charAry = new char[s.Length];
        
        for (int i = 0; i < s.Length; i++)
        {
            if (vowelSet.Contains(s[i]))
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