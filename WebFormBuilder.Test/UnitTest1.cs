using WebFormBuilder.Structure;
using WebFormBuilder.Structure.Forms.Text;
using WebFormBuilder.Structure.HtmlCreator;

public class UnitTest1
{
    [Fact]
    public void TestIs_createdThreeForms1()
    {
        // Act
        int expected = 3;
        var formBuilder = new FormBuilder();
        var userName = new TextForm();
        userName.SetLabel("First Name");
        userName.SetName("first_name");
        userName.SetDefaultValue("FirstName");
        userName.SetId("first-name");
        userName.SetClass("firstName");
        formBuilder.Add(userName);
        var lastName = new TextForm();
        lastName.SetLabel("Last Name");
        lastName.SetName("last_name");
        lastName.SetDefaultValue("LastName");
        lastName.SetId("last-name");
        lastName.SetClass("lastName");
        formBuilder.Add(lastName);
        var Age = new SelectForm();
        Age.SetLabel("Age range");
        Age.SetName("age");
        Age.SetDefaultValue("0");
        Age.SetClass("ageSelect");
        Age.SetId("age");
        Age.AddOption("0", "");
        Age.AddOption("1", "<18");
        Age.AddOption("2", "18-30");
        Age.AddOption("3", "31-43");
        Age.AddOption("4", "44-56");
        formBuilder.Add(Age);

        // Arrange
        int actual = formBuilder.WebForms.Count;
    
        // Assert
        Assert.Equal(expected,actual);
    }
}