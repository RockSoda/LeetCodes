public class MyCalendar 
{

	readonly List<(int upperBound, int lowerBound)> meetings;
    
    public MyCalendar() 
    {
		meetings = new List<(int, int)>();
    }
    
    public bool Book(int start, int end) 
    {
        if (meetings.Count == 0)
		{
			meetings.Add((start, end));
			return true;
		}

		// get the existing schedule list and sort
		var existing = meetings.ToArray();
		Array.Sort(existing, (a,b)=> (a.upperBound).CompareTo(b.upperBound));
		int length = existing.Length;
		int i;
		int existingStart = 0;
		int existingEnd = 0;
		for (i = 0; i < length; i++)
		{
			existingStart = existing[i].upperBound;
			existingEnd = existing[i].lowerBound;
			if (existingEnd > start) break;
		}

		// if we reach at end of the array and there are no meetings which end before proposed start
		if (i == length)
		{
			meetings.Add((start, end));
			return true;
		}

		// start time and existing start times are same return false
		if (start == existingStart) return false;

		// if new proposed start time is in between existing scheduled meeting time.
		if (start > existingStart && start < existingEnd) return false;
		else if (end > existingStart) return false; // if new proposed end time is in between existing scheduled meeting time.

		// good to schedule a meeting for the proposed time
		meetings.Add((start, end));
		return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */