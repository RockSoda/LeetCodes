public class Solution 
{
    public int MinOperations(string s) 
    {
        int startWithOne = 0, startWithZero = 0;
        char prevOne = '1', prevZero = '0';

        if (s[0] == '1') startWithZero++;
        else startWithOne++;

        for (int i = 1; i < s.Length; i++)
        {
            if(s[i] == prevOne)
            {
                prevOne = prevOne == '1' ? '0' : '1';
                startWithOne++;
                prevZero = prevZero == '1' ? '0' : '1';
            }
            else
            {
                prevZero = prevZero == '1' ? '0' : '1';
                startWithZero++;
                prevOne = prevOne == '1' ? '0' : '1';
            }
        }

        return Math.Min(startWithZero, startWithOne);
    }
}