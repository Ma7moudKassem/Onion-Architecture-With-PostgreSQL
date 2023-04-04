namespace Domain;

public class Employee : BaseEntity
{
    public string Name { get; set; }
    public float Salary { get; set; }
    public string Mobile { get; set; }

    public Guid NationalityId { get; set; }
    public Nationality Nationality { get; set; }

    public ICollection<EmployeeSupplements> EmployeeSupplements { get; set; }
}