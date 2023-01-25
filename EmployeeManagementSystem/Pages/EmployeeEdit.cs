using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementSystem.Pages;

public partial class EmployeeEdit
{
    [Inject] public IEmployeeDataService? EmployeeDataService { get; set; }
    [Inject] public ICountryDataService? CountryDataService { get; set; }

    [Inject] public IJobCategoryDataService? JobCategoryDataService { get; set; }

    [Parameter] public string? EmployeeId { get; set; }

    public Employee Employee { get; set; } = new Employee();

    public List<Country> Countries { get; set; } = new List<Country>();

    public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

    protected override async Task OnInitializedAsync()
    {
        JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList();

        Countries = (await CountryDataService.GetAllCountries()).ToList();

        int.TryParse(EmployeeId, out var employeeId);

        if (employeeId == 0) // new employee created
        {
            // add some defaults
            Employee = new Employee
                { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now, };
        }
        else
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
        }
    }
}