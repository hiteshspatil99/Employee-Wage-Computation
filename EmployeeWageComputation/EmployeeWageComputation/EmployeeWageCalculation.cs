   using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWageCalculation
    {
        public const int WAGE_PR_HR = 20, FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, PRESENT = 1, HALF_DAY = 2;
        int totalSalary, TOTAL_HOUR = 0;
        public void MonthlyEmployeeWage()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            switch (empCheck)
            {
                case PRESENT:
                    this.TOTAL_HOUR = FULL_DAY_HOUR;
                    break;
                case HALF_DAY:
                    this.TOTAL_HOUR = HALF_DAY_HOUR;
                    break;
                default:
                    Console.WriteLine("Employee is Absent for the Day");
                    break;
                    this.totalSalary = WAGE_PR_HR * TOTAL_HOUR;
                    Console.WriteLine("Employee Salary is: " + totalSalary);
            }
    }
}