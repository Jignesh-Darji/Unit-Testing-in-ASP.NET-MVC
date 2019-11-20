using MVCUnitTestingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUnitTestingDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Employees()
        {
            var employees = from e in GetEmployeeList()
                            orderby e.ID
                            select e;
            return View(employees);
        }
        [NonAction]
        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    ID=1,
                    Age=21,
                    JoiningDate= DateTime.Now,
                    Name ="A"
                },
                new Employee()
                {
                    ID=2,
                    Age=22,
                    JoiningDate= DateTime.Now,
                    Name ="B"
                },
                new Employee()
                {
                    ID=3,
                    Age=23,
                    JoiningDate= DateTime.Now,
                    Name ="C"
                },
                new Employee()
                {

                    ID=4,
                    Age=24,
                    JoiningDate= DateTime.Now,
                    Name ="D"
                },
            };
        }
    }
}