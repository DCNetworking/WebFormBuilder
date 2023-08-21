using System.Text;

namespace WebFormBuilder.Structure.HtmlCreator;

public static class HtmlCreator 
{

    public static string Render(this IFormBuilder formBuilder)
    {
        StringBuilder stringBuilder = new();
        foreach (var form in formBuilder.WebForms)
        {
            stringBuilder.Append(form.Render());
            stringBuilder.Append("\n");
        }
        return stringBuilder.ToString();
    }


}