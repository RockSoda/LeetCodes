public class Solution 
{
    public int ReverseBits(int n) 
    {
        string binary = Convert.ToString(n, 2).PadLeft(32 , '0');
        var binAry = binary.ToArray();
        Array.Reverse(binAry);
        binary = new string(binAry);
        return Convert.ToInt32(binary, 2);
    }
}