public class MyCalendar 
{
    private List<(int start, int end)> intervals;

    public MyCalendar() 
    {
        intervals = new List<(int, int)>();
    }
    
    public bool Book(int start, int end) 
    {
        foreach(var booked in intervals) 
        {
            if (Math.Max(booked.start, start) < Math.Min(booked.end, end)) return false;
        }

        intervals.Add((start,end));
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */