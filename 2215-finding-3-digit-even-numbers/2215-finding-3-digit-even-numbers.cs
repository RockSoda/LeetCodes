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

                foreach((int even, int idx) in evens)
                {
                    if(idx == i || idx == j) continue;
                    set.Add(digits[i]*100+digits[j]*10+even);
                }
            }
        }

        return set.ToArray();
    }
}