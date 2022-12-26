using System;
using WireBraindCoffee.StorageApp.Entities;
using WireBraindCoffee.StorageApp.Repositories;

namespace WireBraindCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var em = new GenericRepository<Employee>();
                AddEmployees(em);

            var organization = new GenericRepository<Organization>();
            AddOrganization(organization);

            GetEmployeeById(em);
            Console.ReadLine();



        }

        private static void GetEmployeeById(GenericRepository<Employee> em)
        {
            var employee = em.GetId(1);
            Console.WriteLine($"Emplyee with ID 1 {employee.FirstName}");
        }

        private static void AddEmployees(GenericRepository<Employee> em)
        {
            em.Add(new Employee { FirstName = "Ousmane Ndiaye" });
            em.Add(new Employee { FirstName = "Pape Diouf" });
            em.Save();
        }

        private static void AddOrganization(GenericRepository<Organization> organization)
        {
            organization.Add(new Organization { Name = "Ousmane Tech" });
            organization.Save();
        }
    }
}
