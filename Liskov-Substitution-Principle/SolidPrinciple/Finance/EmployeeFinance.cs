using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.Finance
{
    /*
     * This class is only responsible to handle Employee Finances.
     */
    public class EmployeeFinance : EmployeeRewards
    {

        public virtual double CalculatePay(Employee employee)
        {
            return 0;
        }

        /*
         * The below method will help to calculate the rewards for all types of Employee
         */


        /*
         * Scenerio 2:
         * We are creating separate class for Rewards.
         * We will extend those property.
         * As a result when an EmployeeType will extend this class they will have both calculatePay() & calculateReward() property.
         *
         *
        public virtual double CalculateRewards(Employee employee) { return 100; }

        */
    }
}
