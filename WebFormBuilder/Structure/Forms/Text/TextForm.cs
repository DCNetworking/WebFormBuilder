namespace WebFormBuilder.Structure.Forms.Text;

public sealed class TextForm : WebForm
{
    private int _size;
    public TextForm() : base(FormTypes.Text)
    {
        
    }

    public void SetSize(int size)
    {
        _size = size;
    }
}