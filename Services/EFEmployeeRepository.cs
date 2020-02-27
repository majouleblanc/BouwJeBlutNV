using BouwJeBlutNV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BouwJeBlutNV.Models
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EFEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Employee Create(Employee employeeToCreate)
        {
            context.Add(employeeToCreate);
            context.SaveChanges();
            return employeeToCreate;
        }

        public Employee Delete(Employee employeeToDelete)
        {
            context.Remove(employeeToDelete);
            context.SaveChanges();
            return employeeToDelete;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee employeeChanges)
        {
            context.Update(employeeChanges);
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
