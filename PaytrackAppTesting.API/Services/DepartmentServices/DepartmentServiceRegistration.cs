using PaytrackAppTesting.API.Services.DepartmentServices;

public static class DepartmentServiceRegistration
{
    public static IServiceCollection AddDepartmentsService(this IServiceCollection services)
    {
        return services.AddScoped<IDepartmentService, DepartmentService>();
    }
}