public class Solution 
{
    public bool CanArrange(int[] arr, int k) 
    {
        var freqs = new int[k];
        foreach (var num in arr) freqs[((num % k) + k) % k]++;

        if (freqs[0] % 2 != 0) return false;

        int left = 1, right = freqs.Length-1;
        while(left <= right)
        {
            if(left == right && freqs[left] % 2 != 0) return false;
            if(freqs[left++] != freqs[right--]) return false;
        }
        return true;
    }
}