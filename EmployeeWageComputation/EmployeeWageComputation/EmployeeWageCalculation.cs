   using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWageCalculation
    {
        public const int WAGE_PR_HR = 20, FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, PRESENT = 1, HALF_DAY = 2, TOTAL_DAYS = 20, TOTAL_HOUR = 100;
        int totalSalary, empHr, totalEmpHrs = 0, totalWorkingDays = 0;
        public void MonthlyEmployeeWage()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            while (totalEmpHrs <= TOTAL_HOUR && totalWorkingDays <= TOTAL_DAYS)
            {
                totalWorkingDays++;
                switch (empCheck)
                {
                    case PRESENT:
                        this.empHr += FULL_DAY_HOUR;
                        break;
                    case HALF_DAY:
                        this.empHr += HALF_DAY_HOUR;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent for the Day");
                        break;
                }
                totalEmpHrs += empHr;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHr);

            }
            this.totalSalary = WAGE_PR_HR * totalEmpHrs;
            Console.WriteLine("Here is the Monthly Wage of Emp." + this.totalSalary);

        }
    }
}