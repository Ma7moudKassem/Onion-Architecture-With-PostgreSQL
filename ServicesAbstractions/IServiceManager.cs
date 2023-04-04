namespace ServicesAbstractions;

public interface IServiceManager
{
    IEmployeeService EmployeeService { get; }
    ISupplementService SupplementService { get; }
    INationalityService NationalityService { get; }
}
