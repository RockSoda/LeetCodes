public class Solution 
{
    public int[] MissingRolls(int[] rolls, int mean, int n) 
    {
        int numOfRolls = rolls.Length;
        int sumOfRolls = rolls.Sum();
        
        int sumOfN = mean * (numOfRolls + n) - sumOfRolls;
        
        int val = sumOfN / n;
        int remainds = sumOfN % n;
        
        if(val > 6 || val <= 0 || (val == 6 && remainds > 0)) return new int[]{};
        
        
        var output = new int[n];
        for(int i = 0; i < output.Length; i++)
        {
            output[i] = val;
            
            if(remainds <= 0) continue;
            
            output[i]++;
            remainds--;
        }
        return output;
    }
}