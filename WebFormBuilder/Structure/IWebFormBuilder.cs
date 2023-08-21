namespace WebFormBuilder.Structure;

public interface IWebFormBuilder
{
    public LinkedList<IWebForm> WebForms { get; }    
    public Dictionary<string, string> GetFormValues { get; }
    public Dictionary<string, string> SetBuilderValue { get; }
    public string GetBuilderValue { get; }
}