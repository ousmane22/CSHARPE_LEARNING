﻿using FullStack.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Data
{
    public class FullstackDbContext:DbContext
    {
        public FullstackDbContext(DbContextOptions<FullstackDbContext> options)
            :base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
