public class CustomStack 
{
    private int[] arr;
    int idx;

    public CustomStack(int maxSize) 
    {
        arr = new int[maxSize];
        Array.Fill(arr, -1);
        idx = 0;
    }
    
    public void Push(int x) 
    {
        if (idx >= arr.Length) return;
        arr[idx++] = x;
    }
    
    public int Pop() 
    {
        if (idx <= 0) return -1;

        var output = arr[--idx];
        arr[idx] = -1;
        return output;
    }
    
    public void Increment(int k, int val) 
    {
        for(int i = 0; i < k; i++)
        {
            if(i >= idx) break;
            arr[i] += val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */