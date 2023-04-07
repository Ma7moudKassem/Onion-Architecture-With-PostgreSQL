namespace Services;

public class EmployeeService : BaseService<Employee>
{
    public EmployeeService(IEmpolyeeRepository repository) : base(repository) { }
}