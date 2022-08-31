using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Data
{
    public class EmployeeSalary : Employee 
    {
        public double SalaryAmount { get; set; }
     


        public void PrintEmployeeWithSalary (EmployeeSalary employeeSalary)
        {
            Console.WriteLine("Employee Id: " + employeeSalary.Id);
            Console.WriteLine("Employee Name: " + employeeSalary.Name);
            Console.WriteLine("Employee Gender: " + employeeSalary.Gender);
            Console.WriteLine("Employee Level: " + employeeSalary.Level);
            Console.WriteLine("Employee Department: " + employeeSalary.Department);
            Console.WriteLine("Employee Salary Amount: " + employeeSalary.SalaryAmount);
            


        }
    }
}
