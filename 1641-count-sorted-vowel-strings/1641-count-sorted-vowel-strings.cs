public class Solution 
{
    private int a = 1, e = 1, i = 1, o = 1, u = 1;

    private void Increment() 
    {
		a = a+e+i+o+u;
		e = e+i+o+u;
		i = i+o+u;
		o = o+u;
	}
    
    public int CountVowelStrings(int n) 
    {
        for (int j = 1; j < n; j++) Increment();
    	return a+e+i+o+u;
    }
}