public class Solution 
{
    public int CanBeTypedWords(string text, string brokenLetters) 
    {
        var brokenChars = new bool[26];
        foreach (var c in brokenLetters) brokenChars[c-'a'] = true;
        var aryOfTxt = text.Split(' ');
        var output = aryOfTxt.Length;
        
        foreach (var txt in aryOfTxt)
        {
            if (txt.Any(c => brokenChars[c-'a'])) output--;
        }
        return output;
    }
}