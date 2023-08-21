namespace WebFormBuilder.Structure;

public abstract class Form : IForm
{
    protected FormTypes _formType;
    protected string _label;
    protected string _name;
    protected string _defaultValue;
    protected string _id;
    protected string _className;
    protected readonly Dictionary<string, string> _attributes;
    public Form(FormTypes formType)
    {
        _attributes = new();
        _formType = formType;
    }
    public virtual void SetLabel(string label) => _label = label;
    public virtual void SetName(string name) => _name = name;
    public virtual void SetId(string id) => _id = id;
    public virtual void SetClass(string className) => _className = className;
    public virtual void SetDefaultValue(string defaultValue) => _defaultValue = defaultValue;
    public virtual void SetAttribute(string attributeName, string attributeValue) =>  _attributes.Add(attributeName,attributeValue);

    public virtual string Render()
    {
        ArgumentException.ThrowIfNullOrEmpty(_label);
        ArgumentException.ThrowIfNullOrEmpty(_name);
        ArgumentException.ThrowIfNullOrEmpty(_className);
        ArgumentException.ThrowIfNullOrEmpty(_id);
        return "";
    }
}