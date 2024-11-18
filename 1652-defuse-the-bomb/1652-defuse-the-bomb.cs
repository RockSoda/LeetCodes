public class Solution 
{
    public int[] Decrypt(int[] code, int k) 
    {
        var decoded = new int[code.Length];
        if (k == 0) return decoded;
        
        for (int i = 0; i < decoded.Length; i++)
        {
            int index = k > 0 ? i+1 : i-1;
            for (int j = 0; j < Math.Abs(k); j++)
            {
                if (index < 0) index += decoded.Length;
                decoded[i] += code[index % decoded.Length];
                
                index = k > 0 ? index+1 : index-1;
            }
        }
        
        return decoded;
    }
}