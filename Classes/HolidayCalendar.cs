namespace be_m1_welcome.Classes;

public class HolidayCalendar
{
    private Dictionary<DateTime, string> _holidays = new();

    public bool IsHoliday(DateTime date)
    {
        return _holidays.ContainsKey(date);
    }
}