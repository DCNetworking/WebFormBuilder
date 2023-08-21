namespace WebFormBuilder.Structure;

public class AggregateForm
{
    public Guid Id { get; private set; }
    public int Version { get; private set; }
    public FormBuilder FormBuilder { get; private set; }
}