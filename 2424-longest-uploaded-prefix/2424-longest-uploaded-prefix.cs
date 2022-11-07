public class LUPrefix 
{
    private int longest;
    private bool[] stream;
    
    public LUPrefix(int n) 
    {
        longest = 0;
        stream = new bool[n];
    }
    
    public void Upload(int video) 
    {
        stream[video-1] = true;
        
        if(video-1 == longest)
        {
            while(longest < stream.Length && stream[longest]) longest++;
        }
    }
    
    public int Longest() => longest;
}

/**
 * Your LUPrefix object will be instantiated and called as such:
 * LUPrefix obj = new LUPrefix(n);
 * obj.Upload(video);
 * int param_2 = obj.Longest();
 */