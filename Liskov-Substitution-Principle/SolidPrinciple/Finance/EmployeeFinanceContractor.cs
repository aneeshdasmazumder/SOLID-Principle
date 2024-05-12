using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.Finance
{
    /*
     * This class extends the quality of EmployeeFinance (Parent class) & calculate the pay.
     * 
     * We will no more extend EmployeeFinance class as the salary calculation property is not needed for Contractors.
     */
    public class EmployeeFinanceContractor : EmployeeRewards
    {
        /*
         * Scenerio 1:
         * The contractor employee may have same qualities as other employees but they are some way different.
         * Their salary will be paid my their vendor company.
         * As a result we shouldn't be forced to implement calculatePay() for Contractors.
         * Once EmployeeReward class is extended in this class we will find CalculatePay() giving error.
         * This way contractors class will not be part of other Employee Types bases on payroll company.
         
        public override double CalculatePay(Employee employee)
        {
            throw new NotImplementedException(); // This is because contractor payroll is handled by Vendor company.
        }
        */


        /*
         * Scenerio 2:
         * We are creatiing a separate class for Rewards.
         */
        public override double CalculateRewards(Employee employee)
        {
            employee.Rewards = 50;
            return employee.Rewards;
        }

        
    }
}
