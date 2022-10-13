public class Solution 
{
    private bool IsVowel(char c) =>
        c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    
    public int CountVowelSubstrings(string word) 
    {
        var set = new HashSet<char>();
        int counter = 0;
        
        for(int i = 0; i < word.Length; i++)
        {
            set.Clear();
            for(int j = i; j < word.Length; j++)
            {
                if(!IsVowel(word[j])) break;
                
                set.Add(word[j]);
                if(set.Count == 5) counter++;
            }
        }
        
        return counter;
    }
}