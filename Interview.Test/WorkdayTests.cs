using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview.Test
{
	[TestClass]
	public class WorkdayTests
	{
		[TestMethod]
		public void CalculateWorkdayTest()
		{
            DateTime startDate = DateTime.Now;

            int numberOfWorkdays = 5;

            //Test if start date is a valid DateTime

            Assert.IsTrue(startDate > DateTime.MinValue && startDate < DateTime.MaxValue);

            //Verify Number of work days is a positive integer

            Assert.IsTrue(numberOfWorkdays > 0);


            //Test Calculate Word day Method
            DateTime dt = Workday.CalculateWorkday(DateTime.Parse("03/02/2019"), 2);

            Assert.IsTrue(dt > DateTime.MinValue && dt < DateTime.MaxValue);

        }
	}
}
