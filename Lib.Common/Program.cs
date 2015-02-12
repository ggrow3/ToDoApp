using System;

namespace Lib.Common
{
    public class Program
    {
        public void Main(string[] args)
        {


            var rangeStartTime = DateTime.Today;
            var rangeEndTime = DateTime.Today.AddDays(3);

            var checkStartTime = DateTime.Today;
            var checkEndTime = DateTime.Today.AddDays(1);
            var dateRange = new DateRange(rangeEndTime, rangeEndTime);
            var test = dateRange.IsWithIn(checkStartTime, checkEndTime);
     
           
        }

       

   


     
    }
}
