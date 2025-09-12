public class Solution 
{
    HashSet<char> VowelsSet = new HashSet<char>
    {
        'a', 'e', 'i', 'o', 'u'
    };

    public bool DoesAliceWin(string s) => s.Any(c => VowelsSet.Contains(c));
}