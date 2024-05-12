using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.Finance
{
    /*
     * This class extends the quality of EmployeeFinance (Parent class) & calculate the pay.
     */
    public class EmployeeFinanceFullTime : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.HoursToPay * 10;
        }

        public override double CalculateRewards(Employee employee)
        {
            employee.Rewards = 150;
            return employee.Rewards;
        }

    }
}
