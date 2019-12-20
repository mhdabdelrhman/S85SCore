using S85S.Core.Enums;
using S85S.Core.Models;
using System;

namespace S85S.Core.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime SetTimeFrom(this DateTime dateTime, DateTime time)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, time.Hour, time.Minute, time.Second, time.Millisecond);
        }

        public static DateTime SetDateFrom(this DateTime dateTime, DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond);
        }

        public static DateTime StartOfDay(this DateTime dateTime)
        {
            return dateTime.Date;
        }

        public static DateTime EndOfDay(this DateTime dateTime)
        {
            return dateTime.StartOfDay().AddDays(1).AddSeconds(-1);
        }

        public static DateTime StartOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public static DateTime EndOfMonth(this DateTime dateTime)
        {
            return dateTime.StartOfMonth().AddMonths(1).AddSeconds(-1);
        }

        public static DateTime StartOfYear(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, 1, 1);
        }

        public static DateTime EndOfYear(this DateTime dateTime)
        {
            return dateTime.StartOfYear().AddYears(1).AddSeconds(-1);
        }

        public static int YearDaysCount(this DateTime dateTime)
        {
            var yearStart = new DateTime(dateTime.Year, 1, 1);
            return (int)(yearStart.AddYears(1) - yearStart).TotalDays;
        }

        public static int MonthDaysCount(this DateTime dateTime)
        {
            var monthStart = new DateTime(dateTime.Year, dateTime.Month, 1);
            return (int)(monthStart.AddMinutes(1) - monthStart).TotalDays;
        }

        public static DateTime Trim(this DateTime dateTime, DateTimeTrimPart part = DateTimeTrimPart.Time)
        {
            switch (part)
            {
                case DateTimeTrimPart.Milliseconds:
                    return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
                case DateTimeTrimPart.Seconds:
                    return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0);
                case DateTimeTrimPart.Minutes:
                    return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0);
            }
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        }

        public static bool IsBetween(this DateTime dateTime, DateTimeRange dateTimeRange, RangeCompare rangeCompare = RangeCompare.IncludeStartAndEnd)
        {
            return dateTimeRange.IsInclude(dateTime, rangeCompare);
        }
    }
}
