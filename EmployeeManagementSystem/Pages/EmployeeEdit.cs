using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementSystem.Pages;

public partial class EmployeeEdit
{
    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }
    [Inject]
    public ICountryDataService? CountryDataService { get; set; }
    
    [Inject]
    public IJobCategoryDataService? JobCategoryDataService { get; set;}
    
    [Parameter]
    public string? EmployeeId { get; set; }

    public Employee Employee { get; set; } = new Employee();

    public List<Country> Countries { get; set; } = new List<Country>();

    public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

    protected override async Task OnInitializedAsync()
    {
        Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(
            EmployeeId));

        JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList();
        
        Countries = (await CountryDataService.GetAllCountries()).ToList();
    }
}