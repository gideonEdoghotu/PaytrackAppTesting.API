using PaytrackAppTesting.API.Models;

public interface IDepartmentService
{
    Task CreateDepartmentAsync(Department department);
    Task<IEnumerable<Department>> GetAllDepartmentsAsync();
    //Task<Department> GetDepartmentByIdAsync(Guid id);
    //Task UpdateDepartmentAsync(Guid id, Department updatedDepartment);
    //Task DeleteDepartmentAsync(Guid id);
}