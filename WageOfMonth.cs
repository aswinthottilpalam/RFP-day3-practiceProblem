using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_day3_PracticeProblems
{
    internal class WageOfMonth
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkingDays = 20;
        public static void Main(string[] args)
        {

            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;


            //Computation
            for (int day = 0; day< numOfWorkingDays; day++)
            {
                Random random = new Random()
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                empWage = empHrs * empRatePerHour;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage: " + empWage);
            }

            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
        }
    }
}
