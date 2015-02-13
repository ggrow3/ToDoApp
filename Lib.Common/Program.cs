using System;

namespace Lib.Common
{
    public class Program
    {
        public void Main(string[] args)
        {
            var testDateRange = new Test_DateRange();
            testDateRange.IsDateInDateRange();
            testDateRange.IsDateNotDateInRange();
            testDateRange.IsDateRangeNotInDateRange();
            testDateRange.IsDateRangeNotInDateRange_BadStartDate_GoodEndDate();
            testDateRange.IsDateRangeNotInDateRange_GoodStartDate_BadEndDate();
            testDateRange.IsInDateRangeInDateRange();
            Console.ReadLine();
        }


        public class Test_DateRange {
          

        public void IsDateInDateRange()
            {


                var rangeStartTime = DateTime.Today;
                var rangeEndTime = DateTime.Today.AddDays(3);
                var dateRange = new DateRange(rangeStartTime, rangeEndTime);
                var shouldBetrue = dateRange.IsWithIn(DateTime.Now);
                var methodName = "IsInDateRange";
                OutPutMessage(shouldBetrue, true, methodName);
            }

        public void IsDateNotDateInRange()
            {
                var rangeStartTime = DateTime.Today.AddDays(-5);
                var rangeEndTime = DateTime.Today.AddDays(-3);
                var dateRange = new DateRange(rangeStartTime, rangeEndTime);
                var shouldBetrue = dateRange.IsWithIn(DateTime.Now);
                var methodName = "IsInDateRange";
                OutPutMessage(shouldBetrue, false, methodName);
            }

        public void IsInDateRangeInDateRange()
        {
            var rangeStartTime = DateTime.Today;
            var rangeEndTime = DateTime.Today.AddDays(3);

            var checkStartTime = DateTime.Today;
            var checkEndTime = DateTime.Today.AddDays(1);

            var dateRange = new DateRange(rangeStartTime, rangeEndTime);
            var shouldBetrue = dateRange.IsWithIn(checkStartTime, checkEndTime);
            var methodName = "IsInDateRange";
            OutPutMessage(shouldBetrue, true, methodName);

        }

        public void IsDateRangeNotInDateRange()
        {
            var rangeStartTime = DateTime.Today.AddDays(-5);
            var rangeEndTime = DateTime.Today.AddDays(-4);
            var checkStartTime = DateTime.Today;
            var checkEndTime = DateTime.Today.AddDays(1);

            var dateRange = new DateRange(rangeStartTime, rangeEndTime);
            var result = dateRange.IsWithIn(checkStartTime, checkEndTime);
            var methodName = "NotInDateRange";
            OutPutMessage(result, false, methodName);


        }

        public void IsDateRangeNotInDateRange_GoodStartDate_BadEndDate()
        {
            var rangeStartTime = DateTime.Today.AddDays(-5);
            var rangeEndTime = DateTime.Today.AddDays(-2);
            var goodStartTime = DateTime.Today.AddDays(-4);
            var badEndTime = DateTime.Today.AddDays(1);

            var dateRange = new DateRange(rangeStartTime, rangeEndTime);
            var result = dateRange.IsWithIn(goodStartTime, badEndTime);
            var methodName = "NotInDateRange";
            OutPutMessage(result, false, methodName);
        }

        public void IsDateRangeNotInDateRange_BadStartDate_GoodEndDate()
        {
            var rangeStartTime = DateTime.Today.AddDays(-6);
            var rangeEndTime = DateTime.Today.AddDays(-2);
            var badStartTime = DateTime.Today.AddDays(-7);
            var goodEndTime = DateTime.Today.AddDays(-4);

            var dateRange = new DateRange(rangeStartTime, rangeEndTime);
            var result = dateRange.IsWithIn(badStartTime, goodEndTime);
            var methodName = "NotInDateRange";
            OutPutMessage(result, false, methodName);
        }


        public void OutPutMessage(bool value, bool shouldBeTrue, string functionName = "")
        {
            if (shouldBeTrue == value)
            {
                var output = String.Format("Function {0}. Passed ", functionName);
                Console.WriteLine(output);
                Console.WriteLine();
            }
            else
            {
                var output = String.Format("This should be : {0}. Instead it is {1}", shouldBeTrue, value);
                Console.WriteLine(output);
                Console.WriteLine("Fail");
            }
        }
    }
       
       








    }
}
