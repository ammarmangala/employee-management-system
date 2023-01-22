using EmployeeManagementSystem.Shared.Domain;

namespace EmployeeManagementSystem.Services;

public interface IJobCategoryDataService
{
    Task<IEnumerable<JobCategory>> GetAllJobCategories();
    Task<JobCategory> GetJobCategoryById(int jobCategoryId);
}