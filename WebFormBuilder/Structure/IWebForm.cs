namespace WebFormBuilder.Structure;

public interface IWebForm
{
    public void SetLabel(string label);
    public void SetName(string name);
    public void SetDefaultValue(string name);
    public void SetAttribute(string attributeName,string attributeValue);
}