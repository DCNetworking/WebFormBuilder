namespace WebFormBuilder.Structure;

public class FormBuilder : IFormBuilder
{
    public List<IForm> WebForms { get; } = new();
    public Dictionary<string, string> GetFormValues { get; }
    public Dictionary<string, string> SetBuilderValue { get; }
    public string GetBuilderValue { get; }
    public void Add(IForm form)
    {
        WebForms.Add(form);
    }

    public void Remove(IForm form)
    {
        WebForms.Remove(form);
    }
    
}