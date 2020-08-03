using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        // Inject IEmployeeRepository using Constructor Injection
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // Retrieve employee name and return
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Email;
        }

        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewData["PageTitle"] = "Employee Details";
            ViewData["Employee"] = model;
            return View();
        }

    }
}
