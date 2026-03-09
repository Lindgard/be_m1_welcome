namespace be_m1_welcome.Classes;

public class HolidayCalendar
{
    //! private Dictionary<DateTime as string, string> _holidays = new Dictionary(DateTime as string, string);

    public bool IsHoliday(DateTime date)
    {
        return _holidays.ContainsKey(date);
    }
}