using System;

namespace Lib.Common
{
    public class DateRange
    {
        public DateTime Start { private set; get; }
        public DateTime End { private set; get; }

        public DateRange(DateTime startTime, DateTime endDate)
        {
            this.Start = startTime;
            this.End = endDate;

        }

        public bool IsWithIn(DateTime date)
        {
            var validDate = date >= this.Start && date <= this.End;
            return validDate;
        }

        public bool IsWithIn(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new Exception("Invalid DateRange: start date can not be greater than end date.");
            }
            var validStartDate = startDate >= this.Start;
            var validEndDate = endDate <= this.End;

            return validStartDate && validEndDate;

        }

    }
}