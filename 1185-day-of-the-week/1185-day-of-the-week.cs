public class Solution 
{
    public string DayOfTheWeek(int day, int month, int year) 
    {
        var days = new string[]{"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        var seed = new DateTime(1971, 1, 1); // Fri
        var curr = new DateTime(year, month, day);
        var noDays = (curr - seed).TotalDays + 5;
        
        var remaind = noDays % 7;
        return days[(int)((remaind) % 7)];
    }
}