using Microsoft.AspNetCore.Mvc;
using PaytrackAppTesting.API.Models;

[ApiController]
[Route("[controller]")]
public class DepartmentController : Controller
{
    public DepartmentController(IDepartmentService departmentService)
    {
        _departmentService = departmentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllDepartments()
    {
        var heroes = await _departmentService.GetAllDepartmentsAsync();
        return Ok(heroes);
    }

    [HttpPost]
    public async Task<IActionResult> AddDepartment([FromBody] Department department)
    {
        await _departmentService.CreateDepartmentAsync(department);
        return Ok(await GetAllDepartments());
    }

    private readonly IDepartmentService _departmentService;
}
