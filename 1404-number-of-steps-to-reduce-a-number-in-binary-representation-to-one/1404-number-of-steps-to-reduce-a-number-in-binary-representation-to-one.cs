public class Solution 
{
    public int NumSteps(string s) 
    {
        string DivideByTwo(string num) => num.Substring(0, num.Length-1);

        string AddOne(string num)
        {
            int i = num.Length-1;
            for(; i >= 0; i--)
            {
                if(num[i] == '0') break;
            }
            
            var sb = new StringBuilder();

            if(i == -1)
            {
                sb.Append('1');
                sb.Append('0', num.Length);
            }
            else
            {
                sb.Append(num.Substring(0, i));
                sb.Append('1');
                sb.Append('0', num.Length-i-1);
            }
            
            return sb.ToString();
        }

        var steps = 0;
        while(s.Last() == '0' || s.Count(c => c == '1') != 1)
        {
            s = s.Last() == '1' ? AddOne(s) : DivideByTwo(s);
            steps++;
        }
        return steps;
    }
}