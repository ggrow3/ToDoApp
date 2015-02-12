using System;

namespace Lib.Common
{
    public class DateRange
    {
        public DateTime start { get; }
        public DateTime end { get; }

        public DateRange(DateTime startTime, DateTime endDate)
        {
            this.start = startTime;
            this.end = endDate;

        }

        public bool IsWithIn(DateTime startDate, DateTime endDate)
        {
            var validStartDate = startDate >= this.start && startDate <= this.end;
            var validEndDate = endDate <= this.end && endDate >= this.start;

            return validStartDate && validEndDate;
            ;
        }

    }
}