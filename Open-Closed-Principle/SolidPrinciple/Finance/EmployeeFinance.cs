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
    public class EmployeeFinance
    {
        /*
         * Scenerio 1.
         * Here we see everytime a new Employee Type is added we need to continuously update the CalculatePay() method.
         * This can cause the class to be more prone to bug.
         * Everytime we update the method as Employee Type and each time we need to test & build the class and the dependent class.
         */

        /*
        public virtual double CalculatePay(Employee emp) {
            if (emp.empType.Equals(EmployeeType.FULL_TIME))
                return emp.hoursToPay * 10;
            else if (emp.empType.Equals(EmployeeType.PART_TIME))
                return emp.hoursToPay * 10;
            else if (emp.empType.Equals(EmployeeType.CONTRACTOR))
                return emp.hoursToPay * 15;
            else return 0;
        }
        */

        /* Scenerio 2.
         * To solve this we can use inheritance to extend this class for every new EmployeeType 
         * for that particular EmployeeTypeFinance Class and add their sepecific calculation in the CalculatePay() method
         */

        public virtual double CalculatePay(Employee employee)
        {
            return 0;
        }
    }
}
