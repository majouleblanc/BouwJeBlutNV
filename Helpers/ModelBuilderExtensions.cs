using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BouwJeBlutNV.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "admin",
                    Department = Dept.HR,
                    Email = "admin@BouwJeBlutNV.be"
                },
                new Employee
                {
                    Id = 2,
                    Name = "youssef",
                    Department = Dept.IT,
                    Email = "youssef@BouwJeBlutNV.be"
                },
                new Employee
                {
                    Id = 3,
                    Name = "john",
                    Department = Dept.HR,
                    Email = "john@BouwJeBlutNV.be"
                },
            new Employee
            {
                Id = 4,
                Name = "kaya",
                Department = Dept.HR,
                Email = "kaya@BouwJeBlutNV.be"
            },
               new Employee
               {
                   Id = 5,
                   Name = "marie",
                   Department = Dept.IT,
                   Email = "marie@BouwJeBlutNV.be"
               },
                new Employee
                {
                    Id = 6,
                    Name = "tim",
                    Department = Dept.IT,
                    Email = "tim@BouwJeBlutNV.be"
                },
                new Employee
                {
                    Id = 7,
                    Name = "tolan",
                    Department = Dept.Payroll,
                    Email = "tolan@BouwJeBlutNV.be"
                },
            new Employee
            {
                Id = 8,
                Name = "victor",
                Department = Dept.Payroll,
                Email = "victor@BouwJeBlutNV.be"
            });
        }
    }
}
