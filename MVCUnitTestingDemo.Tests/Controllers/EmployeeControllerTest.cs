using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCUnitTestingDemo.Controllers;
using MVCUnitTestingDemo.Models;

namespace MVCUnitTestingDemo.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            EmployeeController employeeController = new EmployeeController();
            //Act
            ViewResult result = employeeController.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees()
        {
            //Arrange
            EmployeeController employeeController = new EmployeeController();
            //Act
            ViewResult result = employeeController.Employees() as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void NoOfEmployeesIs4()
        {
            //Arrange
            EmployeeController employeeController = new EmployeeController();
            //Act
           List<Employee> employeelist= employeeController.GetEmployeeList() as List<Employee>;
            //Assert
            Assert.IsTrue(employeelist.Count == 4);
        }

    }
}
