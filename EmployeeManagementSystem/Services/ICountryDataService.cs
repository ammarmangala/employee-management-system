using EmployeeManagementSystem.Shared.Domain;

namespace EmployeeManagementSystem.Services;

public interface ICountryDataService
{
    Task<IEnumerable<Country>> GetAllCountries();
    Task<Country> GetCountryById(int countryId);
}