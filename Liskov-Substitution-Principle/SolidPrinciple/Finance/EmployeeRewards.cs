using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.Finance
{
    /*
     * This class will be the parent of EmployeeFinance.
     * Employee will have their reward calculation from this class.
     * Employee will have their salary calculation from EmployeeFinance class.
     */
    public class EmployeeRewards
    {
        public virtual double CalculateRewards(Employee employee)
        {
            return 100;
        }
    }
}
