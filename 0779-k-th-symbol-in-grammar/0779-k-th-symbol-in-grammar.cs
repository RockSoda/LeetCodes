public class Solution 
{
    //If n == 1, the answer is 0. This is the base case for the recursion.
    //Otherwise, if k is odd, the answer is the same as the k-1 th symbol of n-1 rows.
    //Otherwise, if k is even, the answer is the opposite of the k-1 th symbol of n-1 rows.
    
    public int KthGrammar(int n, int k) 
    {
        if(n == 1) return 0;
        
        if(k % 2 == 1) return KthGrammar(n-1, (k+1)/2);
        else return KthGrammar(n-1, k/2) == 0 ? 1 : 0;
    }
}