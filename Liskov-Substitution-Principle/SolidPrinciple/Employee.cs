using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    /*
     * This class should only be responsible for saving Employee data.
     */  
    public class Employee
    {
        private EmployeeType empType;
        private int hoursToPay;

        private int _rewards;

        public int Rewards 
        {
            get { return _rewards; }
            set { _rewards = value; }
        }

        public int HoursToPay 
        {
            get { return hoursToPay; }
        }

        public Employee(EmployeeType empType, int hoursToPay)
        {
            this.empType = empType;
            this.hoursToPay = hoursToPay;
        }


        /*
         * Initially here there were 3 methods mentioned below.
         * Lets say in a company, there are COO, CFO, CTO.
         * According to the current scenerio, all the three leaders responsibilities are present together.
         * This might cause hectic and issues. 
         * CFO is only responsible for CalculatePay().
         * CTO is only responsible for Save().
         * COO is only responsible for ReportHours().
         * 
         * If all the responsibilities persist together, then one might affect the other and cause a lot of problems and chaos.
         * 
         * So we need to seperate those responsibilities in seperate classes.
         */


        // public double CalculatePay(Employee emp) { }

        // public string ReportHours(Employee emp) { }

        public void Save(Employee emp) {
            try
            {

            } catch (Exception ex)
            {
                // Violating SRP as save is not supposed to print logs. Create separate Logger class
                // System.IO.File.WriteAllText("E:\\System Design\\SOLID", ex.Message);

                Logger log = new Logger();
                log.LogError(ex.Message);
            }
        }

        
    }
}
