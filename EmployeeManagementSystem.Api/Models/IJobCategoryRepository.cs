using EmployeeManagementSystem.Shared.Domain;

namespace EmployeeManagementSystem.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
