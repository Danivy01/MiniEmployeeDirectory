using MiniEmployeeDirectory.Interface;
using MiniEmployeeDirectory.Models;

namespace MiniEmployeeDirectory.Service {
    public class EmployeeService : IEmployeeService {
        public List<Employee> GetEmployees() {
            return new List<Employee> {
                new Employee { ID = 1, EmployeeID = "MA789456", FullName = "Janna Rose A. Chavez", Department = "Accounting Dept.", Position = "Accountant" },
                new Employee { ID = 1, EmployeeID = "MA951852", FullName = "Adelene Kate C. Pilar", Department = "HR Dept.", Position = "Hiring Manager" }
            };
        }
    }
}
