// See https://aka.ms/new-console-template for more information
using SolidPrinciple;
using SolidPrinciple.Finance;

Console.WriteLine("---- Liskov Substitution Principle ----");

/*
 * If class B is a subtype of class A, then we can replace class A with B.
 */

// Creating individual employee
Employee empFTE = new Employee(EmployeeType.FULL_TIME, 10);
Employee empPTE = new Employee(EmployeeType.PART_TIME, 10);
Employee empCont = new Employee(EmployeeType.CONTRACTOR, 10);

EmployeeFinance financeFTE = new EmployeeFinanceFullTime();
var salaryFTE = financeFTE.CalculatePay(empFTE);
Console.WriteLine("Full Time Employee's Salary: " + salaryFTE);
var rewardFTE = financeFTE.CalculateRewards(empFTE);
Console.WriteLine("Full Time Employee's Reward: " + rewardFTE);

EmployeeFinance financePTE = new EmployeeFinancePartTime();
var salaryPTE = financePTE.CalculatePay(empPTE);
Console.WriteLine("Part Time Employee's Salary: " + salaryPTE);
var rewardPTE = financePTE.CalculateRewards(empPTE);
Console.WriteLine("Part Time Employee's Reward: " + rewardPTE);

/*
 * Scenerio 1: When we are trying to calculatePay() for contractor the code is breaking.
 * This is obvious because contractor's payroll will be handled my the vendor.
 
EmployeeFinance financeCont = new EmployeeFinanceContractor();
var salaryCont = financeCont.CalculatePay(empCont);
Console.WriteLine("Contractor Employee's Salary: " + salaryCont);
var rewardCont = financeCont.CalculateRewards(empCont);
Console.WriteLine("Contractor Employee's Reward: " + rewardCont);

*/

/*
 * Scenerio 2:
 * Now we will create the EmployeeFinanceContractor() object with EmployeeReward() class.
 * The Contractor's reward will only be calculated by the company.
 * Since the salary will be provided by the vendor, the contractor class shouldn't hold that property.
 */

EmployeeRewards redwardCont = new EmployeeFinanceContractor();
var rewardCont = redwardCont.CalculateRewards(empCont);
Console.WriteLine("Contractor Employee's Reward: " + rewardCont);




Console.Read();
