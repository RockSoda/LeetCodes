public class Solution 
{
    public int MaximumSwap(int num) 
    {
        var numAry = num.ToString().ToCharArray();
        int max = num;
        for(int i = 0; i < numAry.Length; i++)
        {
            for(int j = i+1; j < numAry.Length; j++)
            {
                if(numAry[j] == 0 || numAry[j] <= numAry[i]) continue;
                
                (numAry[i], numAry[j]) = (numAry[j], numAry[i]);
                max = Math.Max(max, int.Parse(new string(numAry)));
                (numAry[i], numAry[j]) = (numAry[j], numAry[i]);
            }
        }
        return max;
    }
}