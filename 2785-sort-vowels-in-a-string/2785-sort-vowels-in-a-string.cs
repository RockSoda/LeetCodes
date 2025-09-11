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
        
        var charAry = s.ToCharArray();
        
        for (int i = 0; i < charAry.Length; i++)
        {
            var currChar = charAry[i];
            if (!vowelSet.Contains(currChar)) continue;
            
            vowels.Add(currChar);
            indexes.Add(i);
        }
        
        if (vowels.Count == 0) return s;
        
        vowels.Sort();
        
        for(int i = 0; i < vowels.Count; i++) charAry[indexes[i]] = vowels[i];
        
        return new string(charAry);
    }
}