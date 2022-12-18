using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Shared.Domain;

namespace EmployeeManagementSystem.Pages;

public partial class EmployeeOverview
{ 
    public List<Employee>? Employees { get; set; } = default;

    protected override void OnInitialized()
    {
        Employees = MockDataService.Employees;
    }
} 