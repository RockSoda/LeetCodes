public class Solution 
{
    public long MinimumSteps(string s) 
    {
        long numOfZero = 0, steps = 0;
        for (int i = s.Length-1; i >= 0; i--)
        {
            var c = s[i];
            if (c == '0') numOfZero++;
            else steps += numOfZero;
        }
        return steps;
    }
}