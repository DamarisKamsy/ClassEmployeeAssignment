using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Level { get; set; }
        public string Gender { get; set; }

        public void PrintEmployee(int id, string name, string department, int level, string gender)
        {
            Console.WriteLine("Employee Id: " + id) ;
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Gender: " + gender);
            Console.WriteLine("Employee Level: " + level);
            Console.WriteLine("Employee Department: " + department);
            
        
        }
    }
}
