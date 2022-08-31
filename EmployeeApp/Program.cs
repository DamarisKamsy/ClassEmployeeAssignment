// See https://aka.ms/new-console-template for more information
using EmployeeApp.Data;

Console.WriteLine("Welcome To My Employee App");


Employee emp = new Employee();
emp.Id = 1;
emp.Name = "Ada";
emp.Department = "Marketing";
emp.Level = 2;
emp.Gender = "Female";

//emp.PrintEmployee(emp.Id,emp.Name,emp.Department,emp.Level,emp.Gender);

EmployeeSalary empSal = new EmployeeSalary();
empSal.SalaryAmount = 10000;
empSal.Id = 2;
empSal.Name = "John";
empSal.Department = "Operations";
empSal.Level = 3;
empSal.Gender = "Male";

empSal.PrintEmployeeWithSalary(empSal);
empSal.PrintEmployee(empSal.Id, empSal.Name, empSal.Department, empSal.Level, empSal.Gender);
