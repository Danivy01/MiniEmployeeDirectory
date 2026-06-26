using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiniEmployeeDirectory.Interface;
using MiniEmployeeDirectory.Models;
using MiniEmployeeDirectory.Service;

namespace MiniEmployeeDirectory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService employee;

        public HomeController(ILogger<HomeController> logger, IEmployeeService employee)
        {
            _logger = logger;
            this.employee = employee;
        }

        public IActionResult Index()
        {
            var employees = employee.GetEmployees();
            string result = "";
            
            foreach (var emp in employees) {
                result += $"ID: {emp.EmployeeID} Full name: {emp.FullName} Department: {emp.Department} Position: {emp.Position}\n";
            }
            return Content(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
