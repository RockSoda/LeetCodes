public class Solution 
{
    public bool IsValid(string word) 
    {
        if(word.Length < 3) return false;

        var vowels = new HashSet<char>{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

        bool doesContainVowel = false;
        bool doesContainConsonant = false;

        foreach(var c in word)
        {
            bool isDigit = c >= '0' && c <= '9';
            bool isChar = c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z';

            if(!isDigit && !isChar) return false;

            if(isDigit) continue;

            if(vowels.Contains(c)) doesContainVowel = true;
            else doesContainConsonant = true;
        }

        return doesContainVowel && doesContainConsonant;
    }
}