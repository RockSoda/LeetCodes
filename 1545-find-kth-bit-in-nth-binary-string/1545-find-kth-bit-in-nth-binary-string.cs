public class Solution 
{
    public char FindKthBit(int n, int k) 
    {
        string InvertReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i++) charArray[i] = charArray[i] == '1' ? '0' : '1';

            Array.Reverse(charArray);
            return new string(charArray);
        }

        string GetStr(int lap)
        {
            if (lap == 1) return "0";
            
            var prev = GetStr(lap-1);

            var sb = new StringBuilder();
            sb.Append(prev);
            sb.Append('1');
            sb.Append(InvertReverseString(prev));

            return sb.ToString();
        }

        return GetStr(n)[k-1];
    }
}