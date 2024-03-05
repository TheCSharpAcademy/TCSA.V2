namespace TCSA.V2.Helpers;

public static class DateTimeHelper
{
    public static string GetDate(DateTimeOffset date)
    {
        if (date.Year < 2023)
        {
            return "No date recorded";
        }
        return date.DateTime.ToLocalTime().ToString("dddd, MMM dd yyyy");
    }

    public static string GetDateForUserActivity(DateTimeOffset date)
    {
        if (date.Year < 2023)
        {
            return "No date recorded";
        }
        return date.DateTime.ToLocalTime().ToString("MMM dd, yyyy");
    }

    public static string GetTime(DateTimeOffset date)
    {
        if (date.Year < 2023)
        {
            return "No time recorded";
        }

        return date.DateTime.ToLocalTime().ToString("hh:mm tt");
    }

    public static string GetTimeSpan(DateTimeOffset date, DateTime timeNow)
    {
        if (date < new DateTime(2019, 1, 1))
        {
            return "N/A";
        }
        var difference = timeNow - date;
        var hours = difference.Hours != 1 ? "hours" : "hour";
        var days = difference.Days != 1 ? "days" : "day";
        var style = difference.Days > 2 ? "overdue" : "";

        return $"<span class='{style}'>{difference.Days} {days} {difference.Hours} {hours}</span>";
    }
}
