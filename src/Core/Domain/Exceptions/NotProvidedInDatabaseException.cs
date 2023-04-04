namespace Domain;

public abstract class NotProvidedInDatabaseException : Exception
{
    public NotProvidedInDatabaseException(string message) : base(message) { }
}
\