public class Solution 
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B) 
    {
        var setA = new HashSet<int>();
        var setB = new HashSet<int>();
        var ary = new int[A.Length];

        for(int i = 0; i < A.Length; i++)
        {
            int numA = A[i], numB = B[i];

            setA.Add(numA);
            setB.Add(numB);

            if(setA.Contains(numB)) ary[i]++;
            if(setB.Contains(numA)) ary[i]++;

            if(numA == numB) ary[i]--;

            if(i <= 0) continue;

            ary[i] += ary[i-1];
        }

        return ary;
    }
}