public class Solution 
{
    private string ConvertFromDeci(int base1, int inputNum)
    {
        char reVal(int num)
        {
            if (num >= 0 && num <= 9)
                return (char)(num + '0');
            else
                return (char)(num - 10 + 'A');
        }

        string s = "";
    
        // Convert input number is given 
        // base by repeatedly dividing it
        // by base and taking remainder
        while (inputNum > 0)
        {
            s += reVal(inputNum % base1);
            inputNum /= base1;
        }
        char[] res = s.ToCharArray();
    
        Array.Reverse(res);
        return new string(res);
    }

    public bool CheckPowersOfThree(int n) => !ConvertFromDeci(3, n).Any(c => c == '2');
}