using System.Text;
using System.Text.Json;
using Blazored.LocalStorage;
using EmployeeManagementSystem.Shared.Domain;

namespace EmployeeManagementSystem.Services;

public class EmployeeDataService : IEmployeeDataService
{
    private readonly HttpClient _httpClient;
    private readonly ILocalStorageService _localStorageService;

    public EmployeeDataService(HttpClient httpClient, ILocalStorageService localStorageService)
    {
        _httpClient = httpClient;
        _localStorageService = localStorageService;
    }

    public async Task<IEnumerable<Employee>> GetAllEmployees()
    {
        return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>
            (await _httpClient.GetStreamAsync($"api/employee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
    }
    

    public async Task<Employee> GetEmployeeDetails(int employeeId)
    {
        return JsonSerializer.Deserialize<Employee>
        (await _httpClient.GetStringAsync($"api/employee/{employeeId}"),
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
    }

    public async Task<Employee> AddEmployee(Employee employee)
    {
        var employeeJson =
            new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync("api/employee", employeeJson);

        if (response.IsSuccessStatusCode)
        {
            return await JsonSerializer.DeserializeAsync<Employee>(await response.Content.ReadAsStreamAsync());
        }

        return null!;
    }

    public async Task UpdateEmployee(Employee employee)
    {
        var employeeJson =
            new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");

        await _httpClient.PutAsync("api/employee", employeeJson);
    }

    public async Task DeleteEmployee(int employeeId)
    {
        await _httpClient.DeleteAsync($"api/employee/{employeeId}");
    }

}

