using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementSystem.Pages;

public partial class EmployeeOverview
{
    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }
    public List<Employee>? Employees { get; set; } = default;

    private Employee? _selectedEmployee;

    private string Title = "Employee overview";

    protected override async Task OnInitializedAsync()
    {
        Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
    }


    public void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}
