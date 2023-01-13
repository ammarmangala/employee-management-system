using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Shared.Domain;

namespace EmployeeManagementSystem.Pages;

public partial class EmployeeOverview
{
    public List<Employee>? Employees { get; set; } = default;

    private Employee? _selectedEmployee;

    private string Title = "Employee overview";

    protected override void OnInitialized()
    {
        // Get the list of employees from the MockDataService
        Employees = MockDataService.Employees;
    }

    public void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}
