using S85S.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace S85S.Core.Models
{
    public class DateTimeRange
    {
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public bool IsOrdered => End >= Start;

        public DateTimeRange OrderedRange
        {
            get
            {
                if (!IsOrdered)
                    return new DateTimeRange(End, Start);
                return new DateTimeRange(Start, End);
            }
        }

        public double TotalMilliseconds
        {
            get
            {
                var o = OrderedRange;
                return (o.End - o.Start).TotalMilliseconds;
            }
        }

        public double TotalSeconds
        {
            get
            {
                var o = OrderedRange;
                return (o.End - o.Start).TotalSeconds;
            }
        }

        public double TotalMinutes
        {
            get
            {
                var o = OrderedRange;
                return (o.End - o.Start).TotalMinutes;
            }
        }

        public double TotalHours
        {
            get
            {
                var o = OrderedRange;
                return (o.End - o.Start).TotalHours;
            }
        }

        public double TotalDays
        {
            get
            {
                var o = OrderedRange;
                return (o.End - o.Start).TotalDays;
            }
        }

        public DateTimeRange(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public DateTimeRange()
        {
            Start = End = DateTime.Now;
        }

        public bool IsInclude(DateTime dateTime, RangeCompare rangeCompare = RangeCompare.IncludeStartAndEnd)
        {
            var o = OrderedRange;
            switch (rangeCompare)
            {
                case RangeCompare.IncludeStartOnly:
                    return dateTime >= o.Start && dateTime < o.End;
                case RangeCompare.IncludeEndOnly:
                    return dateTime > o.Start && dateTime <= o.End;
                case RangeCompare.ExecludeStartEnd:
                    return dateTime > o.Start && dateTime < o.End;
            }

            return dateTime >= o.Start && dateTime <= o.End;
        }

        public bool IsCross(DateTimeRange other, RangeCompare rangeCompare = RangeCompare.IncludeStartAndEnd)
        {
            return IsInclude(other.Start, rangeCompare) ||
                IsInclude(other.End, rangeCompare) ||
                other.IsInclude(Start, rangeCompare) ||
                other.IsInclude(End, rangeCompare);
        }

        public DateTimeRange Cross(DateTimeRange other, RangeCompare rangeCompare = RangeCompare.IncludeStartAndEnd)
        {
            if (!IsCross(other, rangeCompare))
                return null;
            var ordered = OrderedRange;
            var otherOdered = other.OrderedRange;
            var start = ordered.Start > otherOdered.Start ? ordered.Start : otherOdered.Start;
            var end = ordered.End < otherOdered.End ? ordered.End : otherOdered.End;
            return new DateTimeRange(start, end);
        }
    }
}
