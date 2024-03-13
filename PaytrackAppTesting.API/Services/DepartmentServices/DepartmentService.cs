using Microsoft.EntityFrameworkCore;
using PaytrackAppTesting.API.Data;
using PaytrackAppTesting.API.Models;

namespace PaytrackAppTesting.API.Services.DepartmentServices
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DataContext _dbContext;

        public DepartmentService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _dbContext.Departments.ToListAsync();
        }

        public async Task CreateDepartmentAsync(Department department)
        {
            if (await _dbContext.Departments.AnyAsync(d => d.Name == department.Name))
            {
                throw new InvalidOperationException($"Department with name '{department.Name}' already exists.");
            }

            department.Id = Guid.NewGuid();
            _dbContext.Departments.Add(department);
            await _dbContext.SaveChangesAsync();
        }

    }
}
