public class Solution 
{
    public int TotalFruit(int[] fruits) 
    {
        int max = 0;
        for(int i = 0; i < fruits.Length; i++)
        {
            if(max >= fruits.Length - i) break;
            int curr = 0;
            int b1 = -1;
            int b2 = -1;
            for(int j = i; j < fruits.Length; j++)
            {
                if(b1 == -1 || b1 == fruits[j])
                {
                    curr++;
                    b1 = fruits[j];
                }
                else if(b2 == -1 || b2 == fruits[j])
                {
                    curr++;
                    b2 = fruits[j];
                }
                else break;
            }
            
            max = Math.Max(max, curr);
        }
        
        return max;
    }
}