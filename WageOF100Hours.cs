using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_day3_PracticeProblems
{
    internal class WageOF100Hours
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkingDays = 20;
        public const int maxHoursInMonth = 10;
        public static void Main(string[] args)
        {

            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;


            //Computation
            while(totalEmpHrs <= maxHoursInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
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
                totalEmpHrs += empHrs;                                                                                                                      
                Console.WriteLine("Days: " + totalWorkingDays + " Employee Hours: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
        }
    }
}
