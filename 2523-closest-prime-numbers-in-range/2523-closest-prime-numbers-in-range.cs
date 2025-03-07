public class Solution 
{
    private List<int> GetPrimes(int left, int right)
    {
        if(right == 1) return new List<int>();
        
        int lim = right+1; // exclusive

        var n = new int[lim - 2]; //exclude 1
        for(int i = 2; i <= lim - 1; i++) //initialize the array with integers from 2 to lim
        {
            if((i & 1) == 0) //evens are not primes f & 1 return 0 if f % 2 == 0
            {
                n[i - 2] = 0;
            }
            else
            {
                n[i - 2] = i;
            }
        }

        n[0] = 2;

        int p = 3; //start with a prime. Since 2 is already eliminated, start with 3

        while(p * p < lim)
        {
            for(int i = p * p; i < lim; i += p + p) //remvove multiples of prime. Start at p * p
            {
                n[i - 2] = 0;
            }

            while(n[(p += 2) - 2] == 0) //find next non zero number. This is guaranteed to be a prime.
                ;
        }

        return n.Where(x => x >= left && x != 0).ToList();
    }

    public int[] ClosestPrimes(int left, int right) 
    {
        var primes = GetPrimes(left, right);
        
        if(primes.Count < 2) return new int[]{ -1, -1 };

        var ans = new int[2];
        int min = int.MaxValue;
        for(int i = 1; i < primes.Count; i++)
        {
            int curr = primes[i] - primes[i-1];

            if(curr >= min) continue;
            
            min = curr;
            ans[0] = primes[i-1];
            ans[1] = primes[i];
        }

        return ans;
    }
}