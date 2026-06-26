using MiniEmployeeDirectory.Models;

namespace MiniEmployeeDirectory.Interface {
    public interface IEmployeeService {
        List<Employee> GetEmployees();
    }
}
