using System.Text;

namespace WebFormBuilder.Structure.Forms.Text;

public class SelectForm : Form
{
    protected Dictionary<string, string> _options = new();
    public SelectForm() : base(FormTypes.Select)
    {
    }
    public void AddOption(Dictionary<string, string> options)
    {
        foreach (KeyValuePair<string, string> KvP in options)
        {
            _options.Add(KvP.Key, KvP.Value);
        }
    }

    public void AddOption(string value, string name)
    {
        _options.Add(value,name);
    }
    public override string Render()
    {
        return $"<div class='select_container_formBuilder select_container_formBuilder--{_formType.ToString().ToLower()} select_container_text--for_{_id}' id='select-container-for-{_id}'>\n" +
               $"<label for='{_name}'>{_label}</label>\n" +
               $"<select name='{_name}' id='{_id}' class='select__formBuilder select select-for-{_id} {_className}'>\n"+
               $"{GetOptionsHtml()}" +
               $"</select>\n"+
               $"</div>";
    }
    private string GetOptionsHtml()
    {
        if (_options.Count == 0)
        {
            return "";
        }
        StringBuilder stringBuilder = new();
        foreach (KeyValuePair<string,string> KvP in _options)
        {
            stringBuilder.Append($"<option {(KvP.Key == _defaultValue ? "selected" : "" )} value='{KvP.Key}'>{KvP.Value}</option>\n");
        }

        return stringBuilder.ToString();
    }
    
}