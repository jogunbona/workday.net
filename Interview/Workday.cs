using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Workday
    {

        public static DateTime CalculateWorkday(DateTime startDate, int numberOfWorkdays)
        {
            DateTime endDate = startDate;

            if(startDate < DateTime.MinValue || startDate > DateTime.MaxValue)
            {
                throw new ArgumentException("Start date provided is invalid.");
            }

            if(numberOfWorkdays <= 0)
            {
                throw new ArgumentException("Number of work days provided is invalid.");
            }

            for (int i = 1; i <= numberOfWorkdays; i++)
            {

                switch (endDate.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                       endDate = endDate.AddDays(3);
                        break;
                    case DayOfWeek.Saturday:
                       endDate = endDate.AddDays(2);
                        break;
                    default:
                       endDate = endDate.AddDays(1);
                        break;
                }

            }

            return endDate;
        }

    }
}
