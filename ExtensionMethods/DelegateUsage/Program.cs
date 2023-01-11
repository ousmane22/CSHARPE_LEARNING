using System;
using System.Collections.Generic;

namespace DelegateUsage
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { Id = 10, Name = "Ousmane ndiaye", Salary = 10000, Experience = 5 });
            employees.Add(new Employee() { Id = 11, Name = "Fatou ndiaye", Salary = 10000, Experience = 3 });
            employees.Add(new Employee() { Id = 12, Name = "Amy ndiaye", Salary = 10000, Experience = 10 });
            employees.Add(new Employee() { Id = 13, Name = "Saliou ndiaye", Salary = 10000, Experience = 5 });

            Employee.PromotedEmployee(employees);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public static void PromotedEmployee(List<Employee> employeeList)
        {
            foreach(Employee employee in employeeList)
            {
                if(employee.Experience >= 5)
                {
                    Console.WriteLine($"{employee.Name} - promoted");
                }
            }
        }
    }
}
