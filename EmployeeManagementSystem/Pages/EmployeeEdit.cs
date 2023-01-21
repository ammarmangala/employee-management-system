using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementSystem.Pages;

public partial class EmployeeEdit
{
    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }
    
    [Parameter]
    public string? EmployeeId { get; set; }

    public Employee Employee { get; set; } = new Employee();

    protected override async Task OnInitializedAsync()
    {
        Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(
            EmployeeId));
    }
}