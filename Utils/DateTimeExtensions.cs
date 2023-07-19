using System.Data.SqlTypes;

namespace Utils;

public static class DateTimeExtensions
{
    public static DateTime ClampSqlDateTime(this DateTime dateTime)
    {
        if (dateTime < SqlDateTime.MinValue)
        {
            dateTime = (DateTime)SqlDateTime.MinValue;
        }
        return dateTime;
    }

    public static DateTime? ClampSqlDateTime(this DateTime? dateTime)
    {
        if (dateTime == null) { return dateTime; }
        if (dateTime.Value < SqlDateTime.MinValue)
        {
            dateTime = (DateTime)SqlDateTime.MinValue;
        }
        return dateTime;
    }
}
