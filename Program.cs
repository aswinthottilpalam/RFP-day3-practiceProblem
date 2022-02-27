using System;

namespace RFP_day3_PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int isFullTime = 1;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
