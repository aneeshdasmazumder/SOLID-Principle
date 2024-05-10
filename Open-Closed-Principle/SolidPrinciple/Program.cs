// See https://aka.ms/new-console-template for more information
using SolidPrinciple;
using SolidPrinciple.Finance;

Console.WriteLine("---- Open AND Closed Principle ----");

// Creating individual employee
Employee empFTE = new Employee(EmployeeType.FULL_TIME, 10);
Employee empPTE = new Employee(EmployeeType.PART_TIME, 10);
Employee empCont = new Employee(EmployeeType.CONTRACTOR, 10);

/*
 * Scenerio 1.
 * Here Employee Type is send to the EmployeeFinance class.
 * EmployeeFinance class checks the EmployeeType and returns the salary to be paid.
 * Now everytime we add a new EmployeeType and everytime we need to validate the EmployeeType in EmployeeFinance class
 * and do the calculation which makes the class more prone to bug as the class is already running successfully in the server.
 */

/*
EmployeeFinance finance = new EmployeeFinance();
var salaryFTE = finance.CalculatePay(empFTE);
var salaryPTE = finance.CalculatePay(empPTE);
var salaryCont = finance.CalculatePay(empCont);
*/

/*
 * Scenerio 2.
 * Now for every new Employee Type we add in the future, we don't need to update the CalculatePay() method in EmployeeFinance class.
 * We can create a subclass of that particular EmployeeType and put the specific calculation in CalculatePay() method of that class.
 */
EmployeeFinance financeFTE = new EmployeeFinanceFullTime();
var salaryFTE = financeFTE.CalculatePay(empFTE);

EmployeeFinance financePTE = new EmployeeFinancePartTime();
var salaryPTE = financePTE.CalculatePay(empPTE);

EmployeeFinance financeCont = new EmployeeFinanceContractor();
var salaryCont = financeCont.CalculatePay(empCont);


Console.WriteLine("Full Time Employee's Salary: " + salaryFTE);
Console.WriteLine("Part Time Employee's Salary: " + salaryPTE);
Console.WriteLine("Contractor Employee's Salary: " + salaryCont);

Console.Read();
