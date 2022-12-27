using System;
using WireBraindCoffee.StorageApp.Data;
using WireBraindCoffee.StorageApp.Entities;
using WireBraindCoffee.StorageApp.Repositories;

namespace WireBraindCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var em = new SqlRepository<Employee>(new StorageAppDbContext());
                AddEmployees(em);

            var organization = new SqlRepository<Organization>(new StorageAppDbContext());
            AddOrganization(organization);

            getAll(em);

            GetEmployeeById(em);
            Console.ReadLine();



        }

        private static void getAll(IRepository<Employee> em)
        {
            var empl = em.GetAll();

            foreach (var item in empl)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetEmployeeById(IRepository<Employee> em)
        {
            var employee = em.GetId(1);
            Console.WriteLine($"Emplyee with ID 1 {employee.FirstName}");
        }

        private static void AddEmployees(IRepository<Employee> em)
        {
            em.Add(new Employee { FirstName = "Ousmane Ndiaye" });
            em.Add(new Employee { FirstName = "Pape Diouf" });
            em.Save();
        }

        private static void AddOrganization(IRepository<Organization> organization)
        {
            organization.Add(new Organization { Name = "Ousmane Tech" });
            organization.Save();
        }
    }
}
