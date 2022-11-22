public class Solution 
{
    public int ScoreOfParentheses(string s) 
    {
        int score = 0;
        int pow = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(') pow++;
            else
            {
                pow--;
                if(s[i-1] == '(') score += (int)Math.Pow(2, pow);
            }
        }
        
        return score;
    }
}