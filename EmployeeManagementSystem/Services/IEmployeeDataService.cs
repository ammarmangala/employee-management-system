using EmployeeManagementSystem.Shared.Domain;

namespace EmployeeManagementSystem.Services;

public interface IEmployeeDataService
{
    Task<IEnumerable<Employee>> GetAllEmployees();
    Task<Employee> GetEmployeeDetails(int employeeId);
    Task<Employee> AddEmployee(Employee employee);
    Task UpdateEmployee(Employee employee);
    Task DeleteEmployee(int employeeId);
}