using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BouwJeBlutNV.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BouwJeBlutNV.Controllers
{
    [Route("[controller]/[action]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            this.repository = repository;
        }
        // GET: /<controller>/
        public IActionResult Employees()
        {
            IEnumerable<Employee> model = repository.GetAllEmployees();
            return View(model);
        }
    }
}
