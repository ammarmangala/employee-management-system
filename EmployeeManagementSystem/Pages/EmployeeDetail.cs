using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementSystem.Pages;

public partial class EmployeeDetail
{
    
    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }
    [Parameter] public string EmployeeId { get; set; }

    public Employee? Employee { get; set; }  = new Employee();

    protected async override Task OnInitializedAsync()
    {
        Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
    }
}
