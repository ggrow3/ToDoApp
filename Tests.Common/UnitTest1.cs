using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Common
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var rangeStartTime = DateTime.Today;
            var rangeEndTime = DateTime.Today.AddDays(3);

            var checkStartTime = DateTime.Today;
            var checkEndTime = DateTime.Today.AddDays(1);
            var dateRange = new DateRange(rangeStartTime, rangeEndTime);
            var test = dateRange.IsWithIn(checkStartTime, checkEndTime);
        }
    }
}
