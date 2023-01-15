using EmployeeManagementSystem.Shared.Domain;

namespace EmployeeManagementSystem.Api.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
