public class Solution 
{
    public int MinimizeXor(int num1, int num2) 
    {
        var bin1 = Convert.ToString(num1, 2);
        var numOfBits1 = bin1.Count(c => c == '1');
        var bin2 = Convert.ToString(num2, 2);
        var numOfBits2 = bin2.Count(c => c == '1');

        if(numOfBits1 == numOfBits2) return num1;

        bin1 = bin1.PadLeft(bin1.Length + numOfBits2, '0');

        var output = new char[bin1.Length];
        Array.Fill(output, '0');
        
        for(int i = 0; i < bin1.Length; i++)
        {
            if(numOfBits2 == 0) break;

            if(bin1[i] == '1') numOfBits2--;

            output[i] = bin1[i];
        }

        for(int i = output.Length - 1; i >= 0; i--)
        {
            if(numOfBits2 == 0) break;

            if(output[i] == '1') continue;

            output[i] = '1';
            numOfBits2--;
        }

        return Convert.ToInt32(new string(output), 2);
    }
}