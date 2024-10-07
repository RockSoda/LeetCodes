public class Solution 
{
    public int MinLength(string s) 
    {
        void Replace()
        {
            s = s.Replace("AB", string.Empty);
            s = s.Replace("CD", string.Empty);
        }

        var prevLen = s.Length;

        while (true)
        {
            Replace();
            if (prevLen == s.Length) break;
            prevLen = s.Length;
        }
        return s.Length;
    }
}