namespace WebFormBuilder.Structure;

public interface IForm
{
    public void SetLabel(string label);
    public void SetName(string name);
    public void SetId(string id);
    public void SetClass(string className);
    public void SetDefaultValue(string name);
    public void SetAttribute(string attributeName,string attributeValue);
    public string Render();
}