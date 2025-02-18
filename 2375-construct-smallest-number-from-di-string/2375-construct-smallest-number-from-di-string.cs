public class Solution 
{
    public string SmallestNumber(string pattern) 
    {
        var min = string.Empty;
        bool IsValidNum(string str)
        {
            if(!string.IsNullOrEmpty(min) && string.Compare(str, min) > 0) return false;

            for(int i = 0 ; i< pattern.Length; i++)
            {
                var curr = pattern[i];
                if(curr == 'I')
                {
                    if(str[i] >= str[i+1]) return false;
                }
                else //curr == 'D'
                {
                    if(str[i] <= str[i+1]) return false;
                }
            }
            return true;
        }

        void FindMinFromAllValidNums(int n, string str)
        {
            if (str.Length >= n) 
            {
                if(!IsValidNum(str)) return;

                if(string.IsNullOrEmpty(min) || string.Compare(min, str) > 0) min = str;
                return;
            }

            for(int i = 1; i <= n; i++)
            {
                var iStr = i.ToString();
                if(str.Contains(iStr)) continue;

                FindMinFromAllValidNums(n, str+iStr);
            }
        }

        FindMinFromAllValidNums(pattern.Length+1, string.Empty);
        
        return min;
    }
}