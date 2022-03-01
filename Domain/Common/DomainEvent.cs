namespace Domain.Common;

public interface IHasDomainEvent
{
    public List<DomainEvent> DomainEvents { get; set; }
}

public class DomainEvent
{
    protected DomainEvent()
    {
        DateOcurred = DateTimeOffset.UtcNow;
    }

    public bool IsPublished { get; set; }

    public DateTimeOffset DateOcurred { get; set; }
}