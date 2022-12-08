using System;
using System.Collections.Generic;

namespace EmployeeRegistration
{
    class Program
    {
        private static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************************");
            Console.WriteLine("**Employee Management NDIAYE TECH**");
            Console.WriteLine("*************************************");

            Console.ForegroundColor = ConsoleColor.White;

            string userSelection;


            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("*********************************");
                Console.WriteLine("**Select an Action please**");
                Console.WriteLine("*********************************");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1: Register Employee");
                Console.WriteLine("2: Register Register Work hours for employee");
                Console.WriteLine("9: Quit Application");


                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        RegisterEmployee();
                        break;

                    case "2":
                        RegisterWork();
                        break;

                   
                    case "9":
                        break;

                    default:
                        Console.WriteLine("Invalid section , please try");
                        break;
                }

            } while (userSelection != "9");
        }

       

        private static void RegisterWork()
        {
            Console.WriteLine("Select an Employer");
            
            for(int i = 1;i<=employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i -1].FirstName } {employees[i-1].LastName}");
            }

            int selected = int.Parse(Console.ReadLine());

            Console.WriteLine("Give the Total hours");

            int hours = int.Parse(Console.ReadLine());

            Employee seletedEmployee = employees[selected - 1];

            int numberOfHourlyWork =  seletedEmployee.PerformWork(hours);

            Console.WriteLine($"{employees[selected - 1].FirstName} {employees[selected - 1].LastName} has {numberOfHourlyWork} hours of work");

        }

        private static void RegisterEmployee()
        {
            Console.WriteLine("Give the first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Give the last name");
            string lname = Console.ReadLine();
            Console.WriteLine("Give the Hourly Rate");
            double hlate =double.Parse(Console.ReadLine());

            Employee employee = new Employee(fname, lname, hlate);
            employees.Add(employee);

            Console.WriteLine("Employed added");
        }
    }
}
