public class Solution 
{
    public int LongestBalanced(string s) 
    {
        bool IsBalanced(int[] arr)
        {
            var num = -1;
            foreach(var x in arr)
            {
                if(x == 0) continue;
                if(num == -1) num = x;
                else
                {
                    if(num != x) return false;
                }
            }
            return true;
        }

        var maxLen = 0;
        for(int i = 0; i < s.Length; i++)
        {
            var map = new int[26];
            for(int j = i; j < s.Length; j++)
            {
                map[s[j]-'a']++;
                if(IsBalanced(map)) maxLen = Math.Max(maxLen, j-i+1);
            }
        }
        return maxLen;
    }
}