   using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWageCalculation
    {
        public const int WAGE_PR_HR = 20, FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, IS_PRESENT = 1, IS_ABSENT = 2;
        int totalSalary, TOTAL_HOUR = 0;
        public void EmployeeDailyWage()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            if (empCheck == 1)
            {
                this.TOTAL_HOUR = FULL_DAY_HOUR;
            }
            if (empCheck == 2)
            {
                this.TOTAL_HOUR = HALF_DAY_HOUR;
            }
            else
                Console.WriteLine("Employee is Absent");

            this.totalSalary = WAGE_PR_HR * TOTAL_HOUR;
            Console.WriteLine("Employee Salary is: " + this.totalSalary);
        }
    }
}