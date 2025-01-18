public class Solution 
{
    public int[] FindEvenNumbers(int[] digits) 
    {
        var evens = new List<(int, int)>();
        Array.Sort(digits);
        for(int i = 0; i < digits.Length; i++)
        {
            var digit = digits[i];
            if(digit % 2 == 0) evens.Add((digit, i));
        }
        var set = new HashSet<int>();
        for(int i = 0; i < digits.Length; i++)
        {
            if(digits[i] == 0) continue;
            for(int j = 0; j < digits.Length; j++)
            {
                if(i == j) continue;

                var sb = new StringBuilder();
                sb.Append((char)(digits[i]+'0'));
                sb.Append((char)(digits[j]+'0'));
                foreach((int even, int idx) in evens)
                {
                    if(idx == i || idx == j) continue;
                    var sbTmp = new StringBuilder(sb.ToString());
                    sbTmp.Append((char)(even+'0'));
                    set.Add(int.Parse(sbTmp.ToString()));
                }
            }
        }

        return set.ToArray();
    }
}