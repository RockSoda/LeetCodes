public class Solution 
{
    public int Candy(int[] ratings) 
    {
        var candies = new int[ratings.Length];

        Array.Fill(candies, 1);
        
        var sum = ratings.Length;
        
        for(int i = ratings.Length-2; i >= 0; i--)
        {
            if(ratings[i] <= ratings[i+1]) continue;
            
            sum -= candies[i];
            candies[i] = candies[i+1]+1;
            sum += candies[i];
        }
        
        for(int i = 1; i < ratings.Length; i++)
        {
            if(ratings[i] <= ratings[i-1] || candies[i-1]+1 <= candies[i]) continue;

            sum -= candies[i];
            candies[i] = candies[i-1]+1;
            sum += candies[i];
        }

        return sum;
    }
}