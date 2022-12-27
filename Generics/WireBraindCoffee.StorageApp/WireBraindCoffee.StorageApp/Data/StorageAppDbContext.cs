using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WireBraindCoffee.StorageApp.Entities;

namespace WireBraindCoffee.StorageApp.Data
{
    public class StorageAppDbContext:DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Organization> Organizations => Set<Organization>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }

  
}
