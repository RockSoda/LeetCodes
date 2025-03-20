public class Solution 
{
    public int MinTimeToType(string word) 
    {
        int GetDist(char c1, char c2)
        {
            var dist = Math.Abs(c1-c2);
            return Math.Min(dist, 26-dist);
        }

        var ans = 0;
        char curr = 'a';
        foreach(var c in word)
        {
            ans += GetDist(curr, c);
            curr = c;
        }
        return ans + word.Length;
    }
}