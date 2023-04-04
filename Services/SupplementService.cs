namespace Services;

public class SupplementService : BaseService<Supplement>
{
    public SupplementService(ISupplementRepository repository) : base(repository) { }
}