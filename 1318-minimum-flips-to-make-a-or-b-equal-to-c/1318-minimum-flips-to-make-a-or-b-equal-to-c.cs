public class Solution 
{
    private string GetReversedBinaryStr(int num)
    {
        var reversedCharAry = Convert.ToString(num, 2).Reverse().ToArray();
        return new string(reversedCharAry);
    }
    
    private bool BitwiseOR(char c1, char c2) => GetBoolFromBit(c1) || GetBoolFromBit(c2);
    
    private bool GetBoolFromBit(char c) => c == '1';
    
    private int GetMaxSize(int a, int b, int c) => Math.Max(Math.Max(a, b), c);
    
    public int MinFlips(int a, int b, int c) 
    {
        string bA = GetReversedBinaryStr(a), bB = GetReversedBinaryStr(b), bC = GetReversedBinaryStr(c);
        
        int counter = 0;
        
        for(int i = 0; i < GetMaxSize(bA.Length, bB.Length, bC.Length); i++)
        {
            char cA = i >= bA.Length ? '0' : bA[i];
            char cB = i >= bB.Length ? '0' : bB[i];
            char cC = i >= bC.Length ? '0' : bC[i];
            bool boolC = GetBoolFromBit(cC);
            
            if(BitwiseOR(cA, cB) == boolC) continue;
            
            if(boolC) counter++;
            else
            {
                if(GetBoolFromBit(cA) && GetBoolFromBit(cB)) counter += 2;
                else counter++;
            }
        }
        
        return counter;
    }
}