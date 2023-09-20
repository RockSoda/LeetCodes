public class Solution 
{
    public string DecodeAtIndex(string s, int k)
    {
        int i = 0;
        long len = 0;
        while (len < k)
        {
            if (Char.IsDigit(s[i]))
            {
                int digit = s[i++] - '0';
                if (len * digit < k) len *= digit;
                else
                {
                    k = k % len == 0 ? (int)len : k % (int)len;
                    i = 0;
                    len = 0;
                }
            }
            else
            {
                i++;
                len++;
            }
        }

        return (k == 0 ? s[0] : s[i - 1]).ToString();
    }
}