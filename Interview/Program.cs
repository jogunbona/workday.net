using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter start date: ");
            string strStartDate = Console.ReadLine();

            //Validate Start Date
            DateTime startDate;
            if (!DateTime.TryParse(strStartDate, out startDate))
            {
                throw new ArgumentException("Start date provided is invalid.");
            }

            Console.WriteLine("\n ");

            Console.WriteLine("Please enter number of work days: ");
            string strNumberOfWorkdays = Console.ReadLine();

            //Validate Number of Work days
            int numberOfWorkdays;
            if (!int.TryParse(strNumberOfWorkdays, out numberOfWorkdays))
            {
                throw new ArgumentException("Start date provided is invalid.");
            }

            Console.WriteLine("\n ");

            DateTime endDate = Workday.CalculateWorkday(startDate, numberOfWorkdays);
            Console.WriteLine(string.Format("{0}-{1}-{2}",endDate.ToString("MMMM"),endDate.Day.ToString(),endDate.Year.ToString()));
            Console.ReadLine();
        }
    }
}
