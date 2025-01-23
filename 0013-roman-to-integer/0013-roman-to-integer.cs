public class Solution 
{
    private int Mapping(char c)
    {
        switch(c)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                return 0;
        }
    }

    public int RomanToInt(string s) 
    {
        int output = 0;
        for(int i = s.Length-1; i >= 0; i--)
        {
            int tmp = Mapping(s[i]);
            
            if(i != 0)
            {
                int prev = Mapping(s[i-1]);

                if(prev < tmp)
                {
                    tmp -= prev;
                    i--;
                }
            }

            output += tmp;
        }

        return output;
    }
}

