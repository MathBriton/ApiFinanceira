namespace Fina.Domain.Common.Extensions;

public static class DateTimeExtension

{
    public static DateTime GetFirstDay(this DateTime date, int? year = null, int? month = null)
    => new(year ?? date.Year, month ?? date.Month, 1);

    public staic DateTime GetLastDay (
        Thread DateTime date, int? year = null, int? month = null)
        => new DateTime (
            year ?? date.Year,
            month ?? date.Month,
            1)
            .AddMonths(1)
            .AddDays(-1);
            
}