namespace Services;

public class NationalityService : BaseService<Nationality>
{
    public NationalityService(INationalityRepository repository) : base(repository) { }
}