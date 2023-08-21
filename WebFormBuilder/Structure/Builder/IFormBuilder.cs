namespace WebFormBuilder.Structure;

public interface IFormBuilder
{
    public List<IForm> WebForms { get; }    
    public Dictionary<string, string> GetFormValues { get; }
    public Dictionary<string, string> SetBuilderValue { get; }
    public string GetBuilderValue { get; }
}