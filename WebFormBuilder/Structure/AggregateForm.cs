namespace WebFormBuilder.Structure;

public class AggregateForm
{
    public Guid Id { get; private set; }
    public int Version { get; private set; }
    public WebFormBuilder WebFormBuilder { get; private set; }
}