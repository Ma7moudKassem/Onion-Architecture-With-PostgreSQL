namespace Domain;

public class EmployeeSupplements : BaseEntity
{
    public Guid EmployeeId { get; set; }

    public Guid SupplementId { get; set; }
    public Supplement Supplement { get; set; }
}