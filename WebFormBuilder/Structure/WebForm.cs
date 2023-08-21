namespace WebFormBuilder.Structure;

public abstract class WebForm : IWebForm
{
    protected FormTypes _formType;
    protected string _label;
    protected string _name;
    protected string _defaultValue;
    protected readonly Dictionary<string, string> _attributes;

    public WebForm(FormTypes formType)
    {
        _attributes = new();
        _formType = formType;
    }
    public virtual void SetLabel(string label)
    {
        _label = label;
    }
    public virtual void SetName(string name)
    {
        _name = name;
    }
    public virtual void SetDefaultValue(string defaultValue)
    {
        _defaultValue = defaultValue;
    }
    public virtual void SetAttribute(string attributeName, string attributeValue)
    {
        _attributes.Add(attributeName,attributeValue);
    }

    public override string ToString()
    {
        return "";
    }
}