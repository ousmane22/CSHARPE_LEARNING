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
            em.Add(new Employee { FirstName = "Ousmane Ndiaye"});
            em.Add(new Employee { FirstName = "Pape Diouf" });
            em.Save();

            var organization = new GenericRepository<Organization>();
            organization.Add(new Organization { Name = "Ousmane Tech" });
            organization.Save();
            Console.ReadLine();



        }
    }
}
