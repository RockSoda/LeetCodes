public class Solution 
{
    public int CanBeTypedWords(string text, string brokenLetters) 
    {
        var brokenChars = new bool[26];
        foreach (var c in brokenLetters) brokenChars[c-'a'] = true;
        var aryOfTxt = text.Split(' ');
        var output = aryOfTxt.Length;

        Array.ForEach(aryOfTxt, txt => output -= txt.Any(c => brokenChars[c-'a']) ? 1 : 0);
        
        return output;
    }
}