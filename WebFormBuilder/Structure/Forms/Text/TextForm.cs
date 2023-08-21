namespace WebFormBuilder.Structure.Forms.Text;

public sealed class TextForm : Form
{
    public TextForm() : base(FormTypes.Text)
    {

    }
    public override string Render()
    {
        return $"<div class='input_container_formBuilder input_container_formBuilder--{_formType.ToString().ToLower()} input_container_text--for_{_id}' id='input-container-for-{_id}'>" +
               $"<label for='{_name}'>{_label}</label>" +
               $"<input type='{_formType.ToString().ToLower()}' name='{_name}' class='input input_formBuilder {_className}' id='{_id}' />" +
               $"</div>";
    }
}