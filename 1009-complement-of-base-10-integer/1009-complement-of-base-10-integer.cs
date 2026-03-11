public class Solution 
{
    public int BitwiseComplement(int n)
    {
        int GetBitWidth(int input)
        {
            var bitWidth = 0;
            while(input > 0)
            {
                bitWidth++;
                input = input >> 1;
            }
            return bitWidth;
        }

        if(n == 0) return 1;
        
        var mask = (1 << GetBitWidth(n)) - 1;
        return n ^ mask;
    }
}