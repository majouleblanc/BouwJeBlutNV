using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BouwJeBlutNV.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);
        Employee Create(Employee employeeToCreate);
        Employee Delete(Employee employeeToDelete);
        Employee Update(Employee employeeChanges);
    }
}
