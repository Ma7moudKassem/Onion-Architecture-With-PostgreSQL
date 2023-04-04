namespace Domain;

public class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public DateTime CreationTime { get; set; } = DateTime.Now;
}